using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.Model;
using ServiceStation.Presenter;

namespace ServiceStation.GridView
{
    internal class WorkJournal : BaseJournal<Work>
    {
        private EditingWorkForm _work;
        private WorkPresenter _presenter;


        internal Guid? ReasonCustomerID { get; set; }


        internal WorkJournal(DataGridView journal) : base(journal) { }

        internal WorkJournal(DataGridView journal, Guid? reasonCustomerID) : base(journal)
        {
            ReasonCustomerID = reasonCustomerID;
        }


        protected override void OperationColumn()
        {
            WightColumn("Nomenclature", 295);
            WightColumn("WorkingHour", 85);
            WightColumn("PriceWorkingHour", 120);
            WightColumn("Amount", 75);
            WightColumn("NormOfTime", 115);
            WightColumn("Sum", 85);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _work = new EditingWorkForm();
                _presenter = new WorkPresenter(_work, (Guid)ReasonCustomerID);
                _work.ShowDialog();

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
                    _work = new EditingWorkForm();
                    _presenter = new WorkPresenter(_work, Item.ID, (Guid)ReasonCustomerID);
                    _work.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтвердате удаление работы?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Work.Where(w => w.ID == Item.ID).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override void Filter(string text)
        {
            Binding.Filter = string.Format("Works LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<Work>> QueryData()
        {
            IEnumerable<Work> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.Work.Where(w => w.ID_reasonCustomer == ReasonCustomerID).Select(w => new Work
                {
                    ID = w.ID,
                    Nomenclature = w.Nomenclature.ShortName,
                    Amount = w.Amount,
                    WorkingHour = w.WorkingHour.Name,
                    PriceWorkingHour = w.WorkingHour.Price,
                    NormOfTime = w.NormOfTime,
                    Sum = w.WorkingHour.Price * w.Amount * w.NormOfTime
                }).OrderBy(w => new { w.Nomenclature, w.WorkingHour }).ToListAsync();
            }

            return result;
        }

        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new WorkModel
            {
                ID = item.ID,
                Nomenclature = new NomenclatureModel { ShortName = item.Nomenclature }
            };
            
            return Task.FromResult(result);
        }
    }
}