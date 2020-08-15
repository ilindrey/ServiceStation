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
    internal class WorkingHourJournal : BaseJournal<WorkingHour>
    {
        private EditingWorkingHourForm _workingHour;
        private WorkingHourPresenter _presenter;


        internal WorkingHourJournal(DataGridView journal) : base(journal) { }


        protected override void OperationColumn()
        {
            WightColumn("Name", 400);
            WightColumn("Price", 125);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _workingHour = new EditingWorkingHourForm();
                _presenter = new WorkingHourPresenter(_workingHour);
                _workingHour.ShowDialog();

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
                    _workingHour = new EditingWorkingHourForm();
                    _presenter = new WorkingHourPresenter(_workingHour, Item.ID);
                    _workingHour.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждате нормочаса?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.WorkingHour.Where(w => w.ID == Item.ID).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить нормочас, поскольку он содержится в одной или нескольких выполняемых работах!");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("Name LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<WorkingHour>> QueryData()
        {
            IEnumerable<WorkingHour> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.WorkingHour.Select(w => new WorkingHour
                {
                    ID = w.ID,
                    Name = w.Name,
                    Price = w.Price
                }).ToListAsync();
            }

            return result;
        }

        internal override Task<object> GetInfo()
        {
            object result = null;
            
            var item = Item;

            result = new WorkingHourModel
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price
            };
            
            return Task.FromResult(result);
        }
    }
}
