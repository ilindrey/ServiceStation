using EntityFramework.Extensions;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class ReasonPresenter : BasePresenter<IEditingReasonView, Guid?>
    {
        internal ReasonPresenter(IEditingReasonView view) : base(view)
        {
            View.Title = string.Concat("Добавление причины обращения");
        }

        internal ReasonPresenter(IEditingReasonView view, Guid reasonID) : base(view, reasonID)
        {
            View.Title = string.Concat("Редактирование причины обращения");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Reason.Where(r => r.ID == (Guid)Identifier).Select(r => new
                    {
                        r.Type,
                        r.ShortName,
                        r.FullName,
                        r.Additionally
                    }).FirstAsync();

                    View.SetReasonInfo(result.ShortName, result.FullName, result.Type, result.Additionally);
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
                var typeManifestation = View.TypeManifestation;
                var shortName = View.ShortName;
                var fullName = View.FullName;
                var additionally = View.Additionally;


                if (string.IsNullOrWhiteSpace(shortName))
                    throw new ArgumentNullException(null, "Вы не ввели краткое наименование причины обращения заказчика!");
                if (string.IsNullOrWhiteSpace(typeManifestation))
                    throw new ArgumentNullException(null, "Вы не выбрали тип проявления!");


                using (var context = new DbSSContext())
                {
                    if(Identifier != null)
                    {
                        await context.Reason.Where(r => r.ID == (Guid)Identifier).UpdateAsync(r => new ReasonModel
                        {
                            Type = typeManifestation,
                            ShortName = shortName,
                            FullName = GetNullValue(fullName),
                            Additionally = GetNullValue(additionally)
                        });
                    }
                    else
                    {
                        ReasonModel insertReasonInfo = new ReasonModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            Type = typeManifestation,
                            ShortName = shortName,
                            FullName = GetNullValue(fullName),
                            Additionally = GetNullValue(additionally)
                        };

                        context.Reason.Add(insertReasonInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertReasonInfo.ID;
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
