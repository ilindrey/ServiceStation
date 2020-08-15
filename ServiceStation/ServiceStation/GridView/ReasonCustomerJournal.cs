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
    internal class ReasonCustomerJournal : BaseJournal<ReasonCustomer>
    {
        private EditingReasonCustomerForm _reasonCustomer;
        private ReasonCustomerPresenter _presenter;


        internal int NumberApplication { get; set; }


        internal ReasonCustomerJournal(DataGridView journal, int numberApplication) : base(journal)
        {
            NumberApplication = numberApplication;
        }


        protected override void OperationColumn()
        {
            WightColumn("ShortName", 325);
            WightColumn("FullName", 400);
            WightColumn("Type", 120);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _reasonCustomer = new EditingReasonCustomerForm();
                _presenter = new ReasonCustomerPresenter(_reasonCustomer, NumberApplication);
                _reasonCustomer.ShowDialog();

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
                    _reasonCustomer = new EditingReasonCustomerForm();
                    _presenter = new ReasonCustomerPresenter(_reasonCustomer, Item.ID, NumberApplication);
                    _reasonCustomer.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы хотите удалить причину обращения заказчика?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.ReasonCustomer.Where(rc => rc.ID == Item.ID).DeleteAsync();
                    };

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
            Binding.Filter = string.Format("ShortName LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<ReasonCustomer>> QueryData()
        {
            IEnumerable<ReasonCustomer> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.ReasonCustomer.Where(rc => rc.Number == NumberApplication).Select(rc => new ReasonCustomer
                {
                    ID = rc.ID,
                    ShortName = rc.Reason.ShortName,
                    FullName = rc.Reason.FullName,
                    Type = rc.Reason.Type,

                    // расчет суммы материалов
                    //PriceMaterial = (rc.Material == null ? 0 : rc.Material.Sum(m => m.Amount * m.Price)),


                    //PriceMaterial = (rc.Material.Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)) == null ? 0

                    //: rc.Material.Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price))),

                    // расчет суммы работ
                    //PriceWork = (rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)) == null ? 0


                    //: rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price))),


                    //расчет цены услуги
                    Price =

                    (rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)) == null ? 0

                    : rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)))


                    +


                    (rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)) == null ? 0


                    : rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)))

                }).OrderBy(rc => new { rc.ShortName, rc.FullName, rc.Type }).ToListAsync();
            }

            return result;
        }
        
        internal override async Task<object> GetInfo()
        {
            object result = null;

            try
            {
                using (var context = new DbSSContext())
                {
                    result = await context.ReasonCustomer.FindAsync(Item.ID);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return result;
        }
    }
}