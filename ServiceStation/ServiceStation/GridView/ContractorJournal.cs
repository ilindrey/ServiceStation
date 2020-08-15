using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.Model;
using ServiceStation.Presenter;

namespace ServiceStation.GridView
{
    // Контрагенты
    internal class ContractorJournal : BaseJournal<Contractor>
    {
        private EditingContractorForm _contractor;
        private ContractorPresenter _presenter;

        
        internal ContractorJournal(DataGridView journal) : base(journal) { }


        protected override void OperationColumn()
        {            
            WightColumn("ShortName", 275);
            WightColumn("FullName", 275);
            WightColumn("INN", 85);
            WightColumn("KPP", 75);
            WightColumn("OKPO", 75);
            WightColumn("Email", 225);
            WightColumn("Phone", 85);
        }
        
        internal override async Task AddRecord()
        {
            try
            {
                _contractor = new EditingContractorForm();
                _presenter = new ContractorPresenter(_contractor);
                _contractor.ShowDialog();

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
                    _contractor = new EditingContractorForm();
                    _presenter = new ContractorPresenter(_contractor, Item.ID);
                    _contractor.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление контрагента?"))
                {
                    using (var context = new DbSSContext())
                    {                        
                        await context.Contractor.Where(c => c.ID == Item.ID).DeleteAsync();
                    }

                    // Обновляем таблицу
                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить контрагента, поскольку он используется в одной или нескольких заявках!");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("ShortName LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<Contractor>> QueryData()
        {
            IEnumerable<Contractor> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Contractor
                .Select(c => new Contractor
                {
                    ID = c.ID,
                    ShortName = c.ShortName,
                    FullName = c.FullName,
                    INN = c.INN,
                    KPP = c.KPP,
                    OKPO = c.OKPO,
                    Email = c.Email,
                    Phone = c.Phone
                }).OrderBy(c => new { c.ShortName, c.FullName }).ToListAsync();
            }

            return result;
        }

        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new ContractorModel
            {
                ID = item.ID,
                ShortName = item.ShortName
            };

            return Task.FromResult(result);
        }
    }
}