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
    internal class OptionCustomerJournal : BaseJournal<OptionCustomer>
    {
        private JournalsForm _journal;


        internal int NumberApplication { get; set; }


        internal OptionCustomerJournal(DataGridView journal) : base(journal) { }

        internal OptionCustomerJournal(DataGridView journal, int numberApplication) : base(journal)
        {
            NumberApplication = numberApplication;
        }


        protected override void OperationColumn()
        {
            WightColumn("ShortName", 350);
            WightColumn("FullName", 500);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _journal = new JournalsForm();

                JournalsPresenter<Option> presenter = new JournalsPresenter<Option>(_journal, new OptionJournal(_journal.Grid, NumberApplication));

                _journal.ShowDialog();

                await Update();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override Task EditRecord()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                return new Task(new Action(() => { }));
            }
        }

        internal override async Task DeleteRecord()
        {
            try
            {
                if (ExistsRecord && ShowConfirmation("Вы хотите удалить причину?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.OptionCustomer.Where(oc => oc.ID == Item.ID).DeleteAsync();
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
            Binding.Filter = string.Format("ShortName LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<OptionCustomer>> QueryData()
        {
            IEnumerable<OptionCustomer> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.OptionCustomer.Where(oc => oc.Number == NumberApplication).Select(oc => new OptionCustomer
                {
                    ID = oc.ID,
                    ShortName = oc.Option.ShortName,
                    FullName = oc.Option.FullName
                })
                .OrderBy(oc => new
                {
                    oc.ShortName,
                    oc.FullName
                }).ToListAsync();
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
                    result = await context.OptionCustomer.FindAsync(Item.ID);
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