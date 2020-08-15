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
    internal class MaterialPresenter : BasePresenter<IEditingMaterialView, Guid?>
    {
        private Guid _reasonCustomerID;
        private int? _numberNomenclature;
        private bool _customer;


        internal MaterialPresenter(IEditingMaterialView view, Guid reasonCustomerID, bool customer) : base(view)
        {
            _customer = customer;
            _reasonCustomerID = reasonCustomerID;
            View.Title = string.Concat("Добавление материала");
        }

        internal MaterialPresenter(IEditingMaterialView view, Guid materialID) : base(view, materialID)
        {
            View.Title = string.Concat("Редактирование материала");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Material.Where(m => m.ID == (Guid)Identifier).Select(m => new
                    {
                        m.ID_reasonCustomer,
                        m.Number_nomenclature,
                        Material = m.Nomenclature.ShortName,
                        m.Amount,
                        m.Price,
                        m.Customer
                    }).FirstAsync();

                    _customer = result.Customer;
                    _reasonCustomerID = result.ID_reasonCustomer;
                    _numberNomenclature = result.Number_nomenclature;

                    View.SetMaterialInfo(result.Material, result.Amount, result.Price);

                    CalculateSum();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        protected override void SubscribeEvent()
        {
            View.Loading += View_Loading;

            View.Save += async () => await SaveAsync();

            View.SelectionNomenclature += () =>
            {
                JournalsForm journal = new JournalsForm();

                JournalsPresenter<Nomenclature> presenter = new JournalsPresenter<Nomenclature>(journal, new NomenclatureJournal(journal.Grid, TypeNomernclature.Good));

                journal.ShowDialog();

                if (presenter.Info != null)
                {
                    NomenclatureModel nomenclature = (NomenclatureModel)presenter.Info;
                    _numberNomenclature = nomenclature.Number;
                    View.Nomenclature = nomenclature.ShortName;
                    View.Price = nomenclature.Price;
                    CalculateSum();
                }
            };

            View.CalculateSum += CalculateSum;
        }


        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
        }


        private void CalculateSum()
        {
            int amount = View.Amount;
            decimal price = View.Price;
            decimal outSum = Math.Round(amount * price, 2);

            View.Sum = string.Concat(outSum);
        }


        protected override async Task SaveAsync()
        {

            try
            {
                if (_numberNomenclature == null)
                    throw new ArgumentNullException(null, "Вы не выбрали материал!");


                var amount = View.Amount;
                var price = View.Price;


                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Material.Where(w => w.ID == (Guid)Identifier).UpdateAsync(w => new MaterialModel
                        {
                            Number_nomenclature = (int)_numberNomenclature,
                            Amount = amount,
                            Price = price
                        });
                    }
                    else
                    {
                        MaterialModel insertMaterialInfo = new MaterialModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            ID_reasonCustomer = _reasonCustomerID,
                            Number_nomenclature = (int)_numberNomenclature,
                            Amount = amount,
                            Customer = _customer,
                            Price = price
                        };

                        context.Material.Add(insertMaterialInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertMaterialInfo.ID;
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