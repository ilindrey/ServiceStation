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
    internal class ModelPresenter : BasePresenter<IEditingModelView, Guid?>
    {
        private Guid? _markID;


        internal ModelPresenter(IEditingModelView view) : base(view)
        {
            View.Title = string.Concat("Добавление модели автомобиля");
        }

        internal ModelPresenter(IEditingModelView view, Guid modelID) : base(view, modelID)
        {
            View.Title = string.Concat("Редактирование модели автомобиля");
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Model.Where(m => m.ID == (Guid)Identifier).Select(m => new
                    {
                        Model = m.Name,
                        ID_mark = m.Mark.ID,
                        Mark = m.Mark.ShortName
                    }).FirstAsync();

                    _markID = result.ID_mark;
                    View.SetModelInfo(result.Mark, result.Model);
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

            View.SelectionMark += SelectionMark;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
        }

        private void SelectionMark()
        {
            JournalsForm journal = new JournalsForm();
            
            JournalsPresenter<Mark> presenter = new JournalsPresenter<Mark>(journal, new MarkJournal(journal.Grid));

            journal.ShowDialog();

            if (presenter.Info != null)
            {
                MarkModel mark = (MarkModel)presenter.Info;
                _markID = mark.ID;
                View.NameMark = mark.ShortName;
            }            
        }


        protected override async Task SaveAsync()
        {
            try
            {
                var name = View.NameModel;

                if (_markID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали модель");
                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentNullException(null, "Вы не ввели имя модели");


                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Model.Where(m => m.ID == Identifier).UpdateAsync(m => new ModelModel
                        {
                            ID_mark = (Guid)_markID,
                            Name = name
                        });
                    }
                    else
                    {
                        ModelModel insertModelInfo = new ModelModel
                        {
                            ID = ConsistentGuid.CreateGuid(),
                            ID_mark = (Guid)_markID,
                            Name = name
                        };

                        context.Model.Add(insertModelInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertModelInfo.ID;
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
