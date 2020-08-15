using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.GridView;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class NomenclaturePresenter : BasePresenter<IEditingNomenclatureView, int?>
    {
        private int? _codeUnit;


        internal NomenclaturePresenter(IEditingNomenclatureView view) : base(view)
        {
            View.Title = string.Concat("Добавление номенклатуры");
        }

        internal NomenclaturePresenter(IEditingNomenclatureView view, int number) : base(view, number) { }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Nomenclature.Where(n => n.Number == (int)Identifier).Select(n => new
                    {
                        n.Number,
                        n.ShortName,
                        n.FullName,
                        n.Type,
                        n.Code_unit,
                        NameUnit = n.Unit.Name,
                        ShortUnit = n.Unit.ShortName,
                        n.VendorCode,
                        n.Price,
                        n.Descriprion
                    }).FirstAsync();

                    View.Title = string.Format("Редактирование номенклатуры №{0}", result.Number);
                    _codeUnit = result.Code_unit;
                    string unit = GetUnitText(result.NameUnit, result.ShortUnit);
                    View.SetNomenclatureInfo(result.Number, result.ShortName, result.FullName, result.Type, unit, result.VendorCode, result.Price, result.Descriprion);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private string GetUnitText(string name, string shortName)
        {
            return string.Concat(name, "(", shortName, ")");
        }

        protected override void SubscribeEvent()
        {
            View.Loading += View_Loading;

            View.Save += async () => await SaveAsync();
            
            View.SelectionUnit += View_SelectionUnit;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
            else
                View.Number = await GetGenerateNumber();
        }

        private void View_SelectionUnit()
        {
            JournalsForm journal = new JournalsForm();

            JournalsPresenter<Unit> presenter = new JournalsPresenter<Unit>(journal, new UnitJournal(journal.Grid));

            journal.ShowDialog();

            if (presenter.Info != null)
            {
                UnitModel unit = (UnitModel)presenter.Info;
                _codeUnit = unit.Code;
                View.NameUnit = GetUnitText(unit.Name, unit.ShortName);
            }
        }

        private async Task<int> GetGenerateNumber()
        {
            int number = 0;

            try
            {
                using (var context = new DbSSContext())
                {
                    while (true)
                    {
                        Random generate = new Random();
                        number = generate.Next(111111, 999999);
                        

                        int verificationNumber = await context.Nomenclature.Where(n => n.Number.Equals(number)).CountAsync();

                        if (verificationNumber == 0)
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return number;
        }
        
        protected override async Task SaveAsync()
        {
            try
            {
                var number = View.Number;
                var shortName = View.ShortName;
                var fullName = View.FullName;
                var type = View.Type;
                var vendorCode = View.VendorCode;
                var price = View.Price;
                var descriprion = View.Descriprion;


                if (string.IsNullOrWhiteSpace(shortName))
                    throw new ArgumentNullException(null, "Вы не ввели краткое наименование номенклатуры!");
                if(_codeUnit == null)
                    throw new ArgumentNullException(null, "Вы не выбрали единицу измерения номенклатуры!");



                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Nomenclature.Where(n => n.Number == (int)Identifier).UpdateAsync(n => new NomenclatureModel
                        {
                            ShortName = shortName,
                            FullName = GetNullValue(fullName),
                            Type = type,
                            Code_unit = (int)_codeUnit,
                            VendorCode = GetNullValue(vendorCode),
                            Price = price,
                            Descriprion = GetNullValue(descriprion)
                        });
                    }
                    else
                    {
                        NomenclatureModel insertNomenclatureInfo = new NomenclatureModel()
                        {
                            Number = number,

                            ShortName = shortName,
                            FullName = GetNullValue(fullName),
                            Type = type,
                            Code_unit = (int)_codeUnit,
                            VendorCode = GetNullValue(vendorCode),
                            Price = price,
                            Descriprion = GetNullValue(descriprion)
                        };

                        context.Nomenclature.Add(insertNomenclatureInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertNomenclatureInfo.Number;
                    }
                }

                View.Close();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
