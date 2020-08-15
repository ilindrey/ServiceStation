using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.Model;
using ServiceStation.Presenter;
using ServiceStation.PrintDocument;

namespace ServiceStation.GridView
{
    // Заявки на ремонт
    internal class ApplicationJournal : BaseJournal<Application>
    {
        private EditingApplicationForm _application;
        private PrintForm _print;
        private ApplicationPresenter _presenter;
        

        internal ApplicationJournal(DataGridView journal) : base(journal) { }


        protected override void OperationColumn()
        {
            WightColumn("Number", 50);
            WightColumn("Date", 100);
            WightColumn("Contractor", 325);
            WightColumn("ContactPerson", 265);
            WightColumn("Car", 200);
            WightColumn("Employee", 250);
        }

        internal void OutputAcceptanceTransferOwnershipCertificate()
        {
            try
            {
                if (ExistsRecord)
                {
                    _print = new PrintForm();
                    _print.Document = new AcceptanceTransferOwnershipCertificate(Item.Number);
                    _print.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal void OutputCertificateCompletion()
        {
            try
            {
                if (ExistsRecord)
                {
                    _print = new PrintForm();
                    _print.Document = new CertificateCompletion(Item.Number);
                    _print.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal void OutputJopTicket()
        {
            try
            {
                if (ExistsRecord)
                {
                    _print = new PrintForm();
                    _print.Document = new JobTicket(Item.Number);
                    _print.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        internal override async Task AddRecord()
        {
            try
            {
                _application = new EditingApplicationForm();
                _presenter = new ApplicationPresenter(_application);
                _application.ShowDialog();

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
                    _application = new EditingApplicationForm();
                    _presenter = new ApplicationPresenter(_application, Item.Number);
                    _application.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление заявки?"))
                {
                    using (var context = new DbSSContext())
                    {
                        await context.Application.Where(a => a.Number == Item.Number).DeleteAsync();
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
            Binding.Filter = string.Format("Contractor LIKE '{0}%'", text);
        }

        protected override async Task<IEnumerable<Application>> QueryData()
        {
            IEnumerable<Application> result = null;


            using (var context = new DbSSContext())
            {
                result = await context.Application.Select(a => new Application
                {
                    Number = a.Number,
                    Date = a.Date,
                    Contractor = a.Car.Contractor.ShortName,
                    Car = a.Car.Model.Name + " VIN: " + a.Car.VIN,
                    ContactPerson = a.PowerOfAttorney.ContactPerson.FFP == null ? null : a.PowerOfAttorney.ContactPerson.FFP,
                    Employee = a.Employee.FFP
                }).OrderBy(a => new { a.Number, a.Contractor }).OrderByDescending(a => a.Date).ToListAsync();

            };

            return result;
        }

        internal override async Task<object> GetInfo()
        {
            object result = null;

            try
            {
                using (var context = new DbSSContext())
                {
                    result = await context.Application.FindAsync(Item.Number);
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