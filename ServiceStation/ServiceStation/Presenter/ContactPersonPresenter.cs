using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using ServiceStation.GridView;
using ServiceStation.InterfacesView;
using ServiceStation.Model;

namespace ServiceStation.Presenter
{
    internal class ContactPersonPresenter : BasePresenter<IEditingContactPersonView, Guid?>
    {
        private const string _messageSaveConfirmation = "Контактное лицо будет сохранено, желаете продолжить?";

        private PowerOfAttorneyJournal _powerOfAttorneyJournal;
        private Guid _contractorID;

        internal ContactPersonPresenter(IEditingContactPersonView view, Guid contractorID) : base(view, _messageSaveConfirmation)
        {
            _contractorID = contractorID;

            View.Title = string.Concat("Добавление контактное лицо");

            _powerOfAttorneyJournal = new PowerOfAttorneyJournal(View.PowerOfAttorneyJournal);
        }

        internal ContactPersonPresenter(IEditingContactPersonView view, Guid contractPersonID, Guid contractorID) : base(view, contractPersonID, _messageSaveConfirmation)
        {
            _contractorID = contractorID;

            View.Title = string.Concat("Редактирование контактного лица");

            _powerOfAttorneyJournal = new PowerOfAttorneyJournal(View.PowerOfAttorneyJournal, (Guid)Identifier);
        }

        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.ContactPerson.Where(cn => cn.ID == (Guid)Identifier)
                     .OrderBy(cn => cn.FFP).Select(cn => new
                     {
                         cn.FFP,
                         cn.Email,
                         cn.Phone,
                         cn.Address,
                         cn.Additionally
                     }).FirstAsync();

                    View.SetContactNameInfo(result.FFP, result.Phone, result.Email, result.Address, result.Additionally);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        protected override void SubscribeEvent()
        {
            View.Save += async () => await SaveAsync();
            View.AddPowerOfAttorney += AddPowerOfAttorney;
            View.EditPowerOfAttorney += EditPowerOfAttorney;
            View.DeletePowerOfAttorney += DeletePowerOfAttorney;
            View.Loading += View_Loading;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
            await _powerOfAttorneyJournal.Update();
        }

        private async Task DeletePowerOfAttorney()
        {
            await _powerOfAttorneyJournal.DeleteRecord();
        }

        private async Task EditPowerOfAttorney()
        {
            await _powerOfAttorneyJournal.EditRecord();
        }

        private async Task AddPowerOfAttorney()
        {
            var verif = await VerificationSaved();

            if (verif)
                await _powerOfAttorneyJournal.AddRecord();
        }

        protected override async Task SaveAsync()
        {
            try
            {
                var FFP = View.FFP;
                var phone = View.Phone;
                var email = View.Email;
                var address = View.Address;
                var additionally = View.Additionally;


                if (string.IsNullOrWhiteSpace(FFP))
                    throw new ArgumentNullException(null, "Вы не ввели имя контактного лица!");

                
                using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.ContactPerson.Where(cn => cn.ID == (Guid)Identifier).UpdateAsync(cn => new ContactPersonModel
                        {
                            FFP = FFP,
                            Phone = GetNullValue(phone),
                            Email = GetNullValue(email),
                            Address = GetNullValue(address),
                            Additionally = GetNullValue(additionally)
                        });
                    }
                    else
                    {
                        Guid id = ConsistentGuid.CreateGuid();
                        ContactPersonModel insertContactPersonInfo = new ContactPersonModel
                        {
                            ID = id,
                            FFP = FFP,
                            Phone = GetNullValue(phone),
                            Email = GetNullValue(email),
                            Address = GetNullValue(address),
                            Additionally = GetNullValue(additionally),
                            ID_сontractor = _contractorID
                        };
                        context.ContactPerson.Add(insertContactPersonInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertContactPersonInfo.ID;
                        _powerOfAttorneyJournal.ContactPersonID = id;
                    }
                }
                if (!openView)
                    View.Close();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
