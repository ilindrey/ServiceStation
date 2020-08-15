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
    internal class ContactPersonJournal : BaseJournal<ContactPerson>
    {
        private EditingContactPersonForm _contactPerson;
        private ContactPersonPresenter _presenter;


        internal Guid? ContractorID { get; set; }


        internal ContactPersonJournal(DataGridView journal) : base(journal) { }

        internal ContactPersonJournal(DataGridView journal, Guid? contractorID) : base(journal)
        {
            ContractorID = contractorID;
        }


        protected override void OperationColumn()
        {
            WightColumn("FFP", 400);
            WightColumn("Email", 225);
            WightColumn("Phone", 85);
        }

        internal override async Task AddRecord()
        {
            try
            {
                _contactPerson = new EditingContactPersonForm();
                _presenter = new ContactPersonPresenter(_contactPerson, (Guid)ContractorID);
                _contactPerson.ShowDialog();

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
                    _contactPerson = new EditingContactPersonForm();
                    _presenter = new ContactPersonPresenter(_contactPerson, Item.ID, (Guid)ContractorID);
                    _contactPerson.ShowDialog();

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
                if (ExistsRecord && ShowConfirmation("Вы подтверждаете удаление контактного лица?"))
                {
                    using (var context = new DbSSContext())
                    {
                        var id = Item.ID;

                        List<Guid?> powerOfAttorneyListID = context.PowerOfAttorney.Where(p => p.ID_contactPerson == id).Select(p => (Guid?)p.ID).ToList();


                        int verificationExistsInApplication = context.Application.Where(a => powerOfAttorneyListID.Contains(a.ID_powerOfAttorney)).Count();


                        if (verificationExistsInApplication > 0)
                            throw new AggregateException();


                        await context.ContactPerson.Where(cn => cn.ID == id).DeleteAsync();
                    }

                    await Update();
                }
            }
            catch (AggregateException)
            {
                ShowError("Нельзя удалить контактное лицо, поскольку он содержится в одной или нескольких заявках!");
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

        protected override async Task<IEnumerable<ContactPerson>> QueryData()
        {
            IEnumerable<ContactPerson> result = null;

            using (var context = new DbSSContext())
            {
                result = await context.ContactPerson.Where(cn => cn.ID_сontractor == ContractorID)
                 .OrderBy(cn => cn.FFP).Select(cn => new ContactPerson
                 {
                     ID = cn.ID,
                     FFP = cn.FFP,
                     Email = cn.Email,
                     Phone = cn.Phone
                 }).ToListAsync();
            }

            return result;
        }

        internal override Task<object> GetInfo()
        {
            object result = null;

            var item = Item;

            result = new ContactPersonModel
            {
                ID = item.ID,
                FFP = item.FFP
            };

            return Task.FromResult(result);
        }
    }
}