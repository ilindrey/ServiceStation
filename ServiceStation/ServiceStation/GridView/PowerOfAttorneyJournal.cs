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
    internal class PowerOfAttorneyJournal : BaseJournal<PowerOfAttorney>
    {
        private EditingPowerOfAttorneyForm _powerOfAttorney;
        private PowerOfAttorneyPresenter _presenter;


        internal Guid ContactPersonID { get; set; }


        internal PowerOfAttorneyJournal(DataGridView journal) : base(journal) { }
        internal PowerOfAttorneyJournal(DataGridView journal, Guid contactPersonID) : base(journal)
        {
            ContactPersonID = contactPersonID;
        }

        protected override void OperationColumn()
        {
            WightColumn("Number", 100);
            WightColumn("Date", 100);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _powerOfAttorney = new EditingPowerOfAttorneyForm();
                _presenter = new PowerOfAttorneyPresenter(_powerOfAttorney, ContactPersonID);
                _powerOfAttorney.ShowDialog();

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
                    _powerOfAttorney = new EditingPowerOfAttorneyForm();
                    _presenter = new PowerOfAttorneyPresenter(_powerOfAttorney, Item.ID, ContactPersonID);
                    _powerOfAttorney.ShowDialog();

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
            Binding.Filter = string.Format("Number LIKE '{0}%'", text);
        }

        internal override async Task DeleteRecord()
        {
            try
            {
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление доверености?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.PowerOfAttorney.Where(pa => pa.ID == Item.ID).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        protected override async Task<IEnumerable<PowerOfAttorney>> QueryData()
        {
            IEnumerable<PowerOfAttorney> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.PowerOfAttorney.Where(p => p.ID_contactPerson == ContactPersonID).Select(p => new PowerOfAttorney
                {
                    ID = p.ID,
                    Number = p.Number,
                    Date = p.Date
                }).OrderBy(p => new { p.Number, p.Date }).ToListAsync();
            }

            return result;
        }


        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new PowerOfAttorneyModel
            {
                ID = item.ID,
                Number = item.Number,
                Date = item.Date
            };

            return Task.FromResult(result);
        }
    }
}