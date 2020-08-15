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
    internal class ContractorPresenter : BasePresenter<IEditingContractorView, Guid?>
    {
        private const string _messageSaveConfirmation = "Контрагент будет сохранен, желаете продолжить?";

        private CarJournal _carJournal;
        private ContactPersonJournal _contactNameJournal;

        
        internal ContractorPresenter(IEditingContractorView view) : base(view, _messageSaveConfirmation)
        {
            View.Title = string.Concat("Добавление контрагента");
            _carJournal = new CarJournal(View.CarsJournal);
            _contactNameJournal = new ContactPersonJournal(View.ContactPersonJournal);
        }

        internal ContractorPresenter(IEditingContractorView view, Guid contractorID) : base(view, contractorID, _messageSaveConfirmation)
        {
            View.Title = string.Concat("Редактирование контрагента");

            _carJournal = new CarJournal(View.CarsJournal, contractorID);
            _contactNameJournal = new ContactPersonJournal(View.ContactPersonJournal, contractorID);
        }


        protected override async Task QueryInfo()
        {
            try
            {
                using (var context = new DbSSContext())
                {
                    var result = await context.Contractor.Where(c => c.ID == (Guid)Identifier)
                    .Select(c => new
                    {
                        c.View,
                        c.ShortName,
                        c.FullName,
                        c.INN,
                        c.KPP,
                        c.OKPO,
                        c.Email,
                        c.Phone,
                        c.Address,
                        c.Additionally
                    }).FirstAsync();


                    View.SetСontractorInfo(result.View, result.ShortName, result.FullName, result.INN.TrimEnd(' '),
                                            result.KPP, result.OKPO, result.Phone, result.Email, result.Address, result.Additionally);
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
            


            View.AddCar += AddCar;
            View.EditCar += EditCar;
            View.DeleteCar += DeleteCar;


            View.AddContactPerson += AddContactPerson;
            View.EditContactPerson += EditContactPerson;
            View.DeleteContactPerson += DeleteContactPerson;


            View.Loading += View_Loading;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
            await _carJournal.Update();
            await _contactNameJournal.Update();
        }

        private async Task AddCar()
        {
            var verif = await VerificationSaved();

            if (verif)
                await _carJournal.AddRecord();
        }

        private async Task EditCar()
        {
            await _carJournal.EditRecord();
        }

        private async Task DeleteCar()
        {
            await _carJournal.DeleteRecord();
        }

        private async Task AddContactPerson()
        {
            var verif = await VerificationSaved();

            if (verif)
                await _contactNameJournal.AddRecord();
        }

        private async Task EditContactPerson()
        {
            await _contactNameJournal.EditRecord();
        }

        private async Task DeleteContactPerson()
        {
            await _contactNameJournal.DeleteRecord();
        }

        protected override async Task SaveAsync()
        {
            try
            {
                var view = View.View;
                var shortName = View.ShortName;
                var INN = View.INN;
                var KPP = View.KPP;
                var OKPO = View.OKPO;
                var fullName = View.FullName;
                var phone = View.Phone;
                var email = View.Email;
                var address = View.Address;
                var additionally = View.Additionally;

                
                if (string.IsNullOrWhiteSpace(view))
                    throw new ArgumentNullException(null, "Вы не выбрали вид контрагента!");
                if (string.IsNullOrWhiteSpace(shortName))
                    throw new ArgumentNullException(null, "Вы не ввели краткое наименование контрагента!");
                if (!string.IsNullOrWhiteSpace(INN) && (INN.Length != 10 && INN.Length != 12))
                    throw new ArgumentNullException(null, "ИНН должен состоять из 10 или 12 цифр!");
                if (!string.IsNullOrWhiteSpace(KPP) && KPP.Length != 9)
                    throw new ArgumentNullException(null, "ОКПО должен состоять из 10 цифр!");


                    using (var context = new DbSSContext())
                {
                    if (Identifier != null)
                    {
                        await context.Contractor.Where(c => c.ID == (Guid)Identifier).UpdateAsync(c => new ContractorModel
                        {
                            View = view,
                            ShortName = shortName,
                            FullName = GetNullValue(fullName),
                            INN = GetNullValue(INN),
                            KPP = GetNullValue(KPP),
                            OKPO = GetNullValue(OKPO),
                            Phone = GetNullValue(phone),
                            Email = GetNullValue(email),
                            Address = GetNullValue(address),
                            Additionally = GetNullValue(additionally)
                        });
                    }
                    else
                    {
                        Guid id = ConsistentGuid.CreateGuid();

                        ContractorModel insertContractorInfo = new ContractorModel
                        {
                            ID = id,
                            View = view,
                            ShortName = shortName,
                            FullName = GetNullValue(fullName),
                            INN = GetNullValue(INN),
                            KPP = GetNullValue(KPP),
                            OKPO = GetNullValue(OKPO),
                            Phone = GetNullValue(phone),
                            Email = GetNullValue(email),
                            Address = GetNullValue(address),
                            Additionally = GetNullValue(additionally)
                        };

                        context.Contractor.Add(insertContractorInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertContractorInfo.ID;

                        _contactNameJournal.ContractorID = id;
                        _carJournal.ContractorID = id;
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
