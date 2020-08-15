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
    internal class EmployeeJournal : BaseJournal<Employee>
    {
        private bool _editingUser = false;
        private EditingEmployeeForm _employee;
        private EmployeePresenter _presender;


        internal EmployeeJournal(DataGridView journal) : base(journal) { }
        internal EmployeeJournal(DataGridView journal, bool editingUser) : base(journal)
        {
            _editingUser = editingUser;
        }


        protected override void OperationColumn()
        {
            WightColumn("FFP", 400);
            WightColumn("Post", 400);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _employee = new EditingEmployeeForm();

                if (_editingUser)
                    _presender = new EmployeePresenter(_employee, _editingUser);
                else
                    _presender = new EmployeePresenter(_employee);

                _employee.ShowDialog();

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
                    _employee = new EditingEmployeeForm();

                    if (_editingUser)
                        _presender = new EmployeePresenter(_employee, Item.ID, _editingUser);
                    else
                        _presender = new EmployeePresenter(_employee, Item.ID);

                    _employee.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждате удаление сотрудника?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Employee.Where(e => e.ID == Item.ID).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException ex)
            {
                ShowError(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
        
        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("FFP LIKE '{0}%'", text);
        }
        
        protected override async Task<IEnumerable<Employee>> QueryData()
        {
            IEnumerable<Employee> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Employee.Select(e => new Employee
                {
                    ID = e.ID,
                    FFP = e.FFP,
                    Post = e.Post.Name
                }).OrderBy(e => new { e.FFP, e.Post }).ToListAsync();
            }

            return result;
        }
        
        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new EmployeeModel
            {
                ID = item.ID,
                FFP = item.FFP
            };

            return Task.FromResult(result);
        }
    }
}
