using EntityFramework.Extensions;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class UnitPresenter : BasePresenter<IEditingUnitView, int?>
    {
        internal UnitPresenter(IEditingUnitView view) : base (view)
        {
            View.Title = string.Concat("Добавление единица измерения");
        }
        internal UnitPresenter(IEditingUnitView view, int unitID) : base(view, unitID)
        {
            View.Title = string.Concat("Редактирование единицы измерения");
        }

        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Unit.Where(u => u.Code == (int)Identifier).Select(u => new
                    {
                        u.Code,
                        u.Name,
                        u.ShortName
                    }).FirstAsync();

                    View.SetUnitInfo(result.Code, result.Name, result.ShortName);
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
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
        }

        protected override async Task SaveAsync()
        {
            try
            {
                var code = View.Code;
                var name = View.NameUnit;
                var shortName = View.ShortName;


                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentNullException(null, "Вы не ввели наименование единицы измерения!");
                if (string.IsNullOrWhiteSpace(shortName))
                    throw new ArgumentNullException(null, "Вы не ввели краткое наименование единицы измерения!");


                using (var context = new DbSSContext())
                {
                    int verihicationCode = context.Unit.Where(u => u.Code == code).Count();

                    if (Identifier != null)
                    {
                        if (Identifier != code && verihicationCode > 0)
                        {
                            ShowError("Такое код уже существует!");
                            return;
                        }

                        await context.Unit.Where(u => u.Code == (int)Identifier).UpdateAsync(u => new UnitModel
                        {
                            Code = code,
                            Name = name,
                            ShortName = shortName
                        });
                    }
                    else
                    {

                        if (verihicationCode > 0)
                        {
                            ShowError("Такое код уже существует!");
                            return;
                        }


                        UnitModel insertUnitInfo = new UnitModel
                        {
                            Code = code,
                            Name = name,
                            ShortName = shortName
                        };

                        context.Unit.Add(insertUnitInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertUnitInfo.Code;
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
