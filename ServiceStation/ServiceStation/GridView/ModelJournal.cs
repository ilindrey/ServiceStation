using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.Model;
using ServiceStation.Presenter;

namespace ServiceStation.GridView
{
    internal class ModelJournal : BaseJournal<Model>
    {
        private EditingModelForm _model;
        private ModelPresenter _present;


        internal ModelJournal(DataGridView journal) : base(journal) { }


        protected override void OperationColumn()
        {
            WightColumn("Name", 400);
            WightColumn("Mark", 500);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _model = new EditingModelForm();
                _present = new ModelPresenter(_model);
                _model.ShowDialog();

                await Update();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override async Task EditRecord()
        {
            try
            {
                if (ExistsRecord)
                {
                    _model = new EditingModelForm();
                    _present = new ModelPresenter(_model, Item.ID);
                    _model.ShowDialog();

                    await Update();
                }

            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override async Task DeleteRecord()
        {
            try
            {
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление модели автотранспортного средства?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Model.Where(m => m.ID == Item.ID).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить модель, поскольку она привязана к одной или нескольким автомобилям!");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Concat("Model LIKE '", text, "%'");
        }

        protected override async Task<IEnumerable<Model>> QueryData()
        {
            IEnumerable<Model> result = null;

            try
            {
                using (var context = new DbSSContext())
                {
                    result = await context.Model.Select(m => new Model
                    {
                        ID = m.ID,
                        Name = m.Name,
                        Mark = m.Mark.ShortName
                    }).OrderBy(m => new { m.Name, m.Mark }).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return result;
        }
        
        internal override Task<object> GetInfo()
        {
            var item = Item;

            ModelModel model = new ModelModel
            {
                ID = item.ID,
                Name = item.Name
            };

            return Task.FromResult((object)model);
        }
    }
}