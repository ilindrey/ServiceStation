using EntityFramework.Extensions;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class WorkingHourPresenter : BasePresenter<IEditingWorkingHourView, Guid?>
    {
        internal WorkingHourPresenter(IEditingWorkingHourView view) : base(view)
        {
            View.Title = string.Concat("Добавление нормо-часа");
        }

        internal WorkingHourPresenter(IEditingWorkingHourView view, Guid workingHourID) : base(view, workingHourID)
        {
            View.Title = string.Concat("Редактирование нормо-часа");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.WorkingHour.Where(wh => wh.ID == (Guid)Identifier).Select(wh => new
                    {
                        wh.Name,
                        wh.Price
                    }).FirstAsync();


                    View.SetWorkingHourInfo(result.Name, result.Price);
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
                var name = View.NameWorkingHour;
                var price = View.Price;
                

                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentNullException(null, "Вы не ввели наименование нормочаса!");


                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.WorkingHour.Where(w => w.ID == Identifier).UpdateAsync(w => new WorkingHourModel
                        {
                            Name = name,
                            Price = price
                        });
                    }
                    else
                    {
                        WorkingHourModel insertWorkingHourInfo = new WorkingHourModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            Name = name,
                            Price = price
                        };

                        context.WorkingHour.Add(insertWorkingHourInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertWorkingHourInfo.ID;
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