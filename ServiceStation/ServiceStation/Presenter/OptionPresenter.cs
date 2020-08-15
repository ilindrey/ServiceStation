using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using ServiceStation.InterfacesView;
using ServiceStation.Model;

namespace ServiceStation.Presenter
{
    internal class OptionPresenter : BasePresenter<IEditingOptionView, Guid?>
    {
        internal OptionPresenter(IEditingOptionView view) : base(view)
        {
            View.Title = string.Concat("Добавление комплектации");
        }

        internal OptionPresenter(IEditingOptionView view, Guid optionID) : base(view, optionID)
        {
            View.Title = string.Concat("Редактирование комплектации");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Option.Where(o => o.ID == (Guid)Identifier).Select(o => new
                    {
                        o.ShortName,
                        o.FullName
                    }).FirstAsync();

                    View.SetOptionInfo(result.ShortName, result.FullName);
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
                var shortName = View.ShortName;
                var fullName = View.FullName;

                if (string.IsNullOrWhiteSpace(shortName))
                    throw new ArgumentNullException(null, "Вы не ввели краткое наименование комплектации");

                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Option.Where(o => o.ID == (Guid)Identifier).UpdateAsync(o => new OptionModel
                        {
                            ShortName = shortName,
                            FullName = GetNullValue(fullName)
                        });
                    }
                    else
                    {
                        OptionModel insertOptionInfo = new OptionModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            ShortName = shortName,
                            FullName = GetNullValue(fullName)
                        };

                        context.Option.Add(insertOptionInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertOptionInfo.ID;
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
