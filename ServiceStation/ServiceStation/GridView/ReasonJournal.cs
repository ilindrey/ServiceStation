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
    internal class ReasonJournal : BaseJournal<Reason>
    {
        private int _numberApplication;
        private EditingReasonForm _reason;
        private ReasonPresenter _presenter;


        internal ReasonJournal(DataGridView journal) : base(journal) { }

        public ReasonJournal(DataGridView journal, int numberApplication) : this(journal)
        {
            this._numberApplication = numberApplication;
        }


        protected override void OperationColumn()
        {
            WightColumn("ShortName", 400);
            WightColumn("FullName", 575);
            WightColumn("Type", 125);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _reason = new EditingReasonForm();
                _presenter = new ReasonPresenter(_reason);
                _reason.ShowDialog();

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
                    _reason = new EditingReasonForm();
                    _presenter = new ReasonPresenter(_reason, Item.ID);
                    _reason.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы действительно хотите удалить причину обращения?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Reason.Where(r => r.ID.Equals(Item.ID)).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (SqlException)
            {
                ShowError("Нельзя удалить причину обращения, поскольку она содержится в одной или нескольких заявках!");
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

        protected override async Task<IEnumerable<Reason>> QueryData()
        {
            IEnumerable<Reason> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Reason.Select(r => new Reason
                {
                    ID = r.ID,
                    ShortName = r.ShortName,
                    FullName = r.FullName,
                    Type = r.Type
                }).ToListAsync();
            }

            return result;
        }

        internal override Task<object> GetInfo()
        {
            object result = null;
            
            var item = Item;

            result = new ReasonModel
            {
                ID = item.ID,
                ShortName = item.ShortName,
                FullName = item.FullName,
                Type = item.Type
            };

            return Task.FromResult(result);
        }
    }
}