using EntityFramework.Extensions;
using ServiceStation.InterfacesView;
using ServiceStation.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ServiceStation.Presenter
{
    internal class MarkPresenter : BasePresenter<IEditingMarkView, Guid?>
    {
        internal MarkPresenter(IEditingMarkView view) : base(view)
        {
            View.Title = string.Concat("Добавление марки автомобиля");
        }

        internal MarkPresenter(IEditingMarkView view, Guid markID) : base(view, markID)
        {
            View.Title = string.Concat("Редактирование марки автомобиля");
        }

        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Mark.Where(m => m.ID == (Guid)Identifier)
                    .Select(m => new
                    {
                        m.ShortName,
                        m.FullName
                    }).FirstAsync();

                    View.SetMarkInfo(result.ShortName, result.FullName);
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
                    throw new ArgumentNullException(null, "Вы не ввели краткое наименование марки автомобиля");


                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Mark.Where(m => m.ID == (Guid)Identifier).UpdateAsync(m => new MarkModel
                        {
                            ShortName = shortName,
                            FullName = GetNullValue(fullName)
                        });
                    }
                    else
                    {
                        MarkModel insertMarkInfo = new MarkModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            ShortName = shortName,
                            FullName = GetNullValue(fullName)
                        };

                        context.Mark.Add(insertMarkInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertMarkInfo.ID;
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