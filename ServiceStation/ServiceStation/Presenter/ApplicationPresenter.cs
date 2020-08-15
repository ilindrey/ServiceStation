using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using ServiceStation.Forms;
using ServiceStation.GridView;
using ServiceStation.InterfacesView;
using ServiceStation.Model;

namespace ServiceStation.Presenter
{
    internal class ApplicationPresenter : BasePresenter<IEditingApplicationView, int?>
    {
        private const string _messageSaveConfirmation = "Заявка будет сохранена, желаете прололжить?";

        private Guid? _carID;
        private Guid? _responsibleID;
        private Guid? _contractorID;
        private Guid? _contractPersonID;
        private Guid? _powerOfAttorneyID;
        private ReasonCustomerJournal _reasonsCustomerJournal;
        private OptionCustomerJournal _optionsCustomerJournal;


        internal ApplicationPresenter(IEditingApplicationView view) : base(view, _messageSaveConfirmation)
        {
            View.Title = string.Concat("Добавление заявки на ремонт");

            View.EnabledContactPerson = true;

         
        }

        internal ApplicationPresenter(IEditingApplicationView view, int number) : base(view, number, _messageSaveConfirmation)
        {
            View.Title = string.Concat("Редактирование заявки на ремонт");

            _optionsCustomerJournal = new OptionCustomerJournal(View.Options, number);
            _reasonsCustomerJournal = new ReasonCustomerJournal(View.Reasons, number);
            
        }


        protected override async Task QueryInfo()
        {
            try
            {

                using (var context = new DbSSContext())
                {
                    var result = await context.Application.Where(a => a.Number == Identifier).Select(a => new
                    {
                        a.Number,
                        a.Date,
                        Contractor = a.Car.Contractor.ShortName,
                        Model = a.Car.Model.Name,
                        a.Car.VIN,
                        ID_contactPerson = a.PowerOfAttorney.ID_contactPerson == null ? null : (Guid?)a.PowerOfAttorney.ID_contactPerson,
                        ContactPerson = a.PowerOfAttorney.ContactPerson.FFP == null ? null : a.PowerOfAttorney.ContactPerson.FFP,
                        ID_contractor = a.Car.Contractor.ID,
                        PowerOfAttorneyNumber = a.PowerOfAttorney.Number == null ? null : a.PowerOfAttorney.Number,
                        PowerOfAttorneyDate = a.PowerOfAttorney.Date == null ? null : (DateTime?)a.PowerOfAttorney.Date,
                        Employee = a.Employee.FFP,
                        a.FirstControlTime,
                        a.SecondControlTime,
                        a.Type,
                        a.Readiness,
                        a.Extradition,
                        a.Revealed,
                        a.Recommendations,
                        a.ID_powerOfAttorney,
                        a.ID_car,
                        a.ID_employee
                    }).FirstAsync();

                    await CalculateSum();

                    _contractorID = result.ID_contractor;
                    _carID = result.ID_car;
                    _responsibleID = result.ID_employee;
                    View.Number = result.Number;
                    string car = GetCarText(result.Model, result.VIN);

                    View.SetApplicationInfo(result.Contractor, car, result.Date, result.FirstControlTime, result.SecondControlTime, result.Readiness, result.Extradition, result.Type, result.Revealed, result.Recommendations, result.Employee);

                    View.EnabledContactPerson = true;

                    if (result.ID_powerOfAttorney != null)
                    {
                        _contractPersonID = result.ID_contactPerson;
                        _powerOfAttorneyID = result.ID_powerOfAttorney;

                        string powerOfAttorneyText = GetPowerOfAttorneyText(result.PowerOfAttorneyNumber, (DateTime)result.PowerOfAttorneyDate);

                        View.SetContactPersonInfo(result.ContactPerson, powerOfAttorneyText);
                        View.EnabledPowerOfAttorney = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        private string GetPowerOfAttorneyText(string number, DateTime date)
        {
            return string.Format("довереность №{0} от {1:dd/MM/yy}", number, date);
        }

        private string GetCarText(string model, string VIN)
        {
            return string.Concat(model, " VIN: ", VIN);
        }

        private async Task<int> GetGenerateNumber()
        {
            int number = 111111;

            try
            {
                using (var context = new DbSSContext())
                {
                    while (true)
                    {
                        Random generate = new Random();
                        number = generate.Next(111111, 999999);

                        int verificationNumber = await context.Application.Where(n => n.Number.Equals(number)).CountAsync();

                        if (verificationNumber == 0)
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return number;
        }

        protected override void SubscribeEvent()
        {
            View.Save += async () => await SaveAsync();

            View.SelectionResponsible += SelectionResponsible;

            View.SelectionContractor += SelectionContractor;

            View.SelectionCar += SelectionCar;

            View.SelectionContactPerson += SelectionContactPerson;

            View.SelectionPowerOfAttorney += SelectionPowerOfAttorney;

            View.ClearContactPerson += ClearContactPerson;


            View.AddOption += AddOption;
            View.DeleteOption += DeleteOption;

            View.AddReason += AddReason;
            View.EditReason += EditReason;

            View.DeleteReason += DeleteReason;
            View.Loading += View_Loading;
        }

        private async Task View_Loading()
        {
            if (Query?.Method != null)
                await Query?.Invoke();
            else
            {
                View.Number = await GetGenerateNumber();
                _optionsCustomerJournal = new OptionCustomerJournal(View.Options, View.Number);
                _reasonsCustomerJournal = new ReasonCustomerJournal(View.Reasons, View.Number);
            }

            await _optionsCustomerJournal.Update();
            await _reasonsCustomerJournal.Update();
        }

        private void SelectionCar()
        {
            JournalsForm journal = new JournalsForm();

            JournalsPresenter<Car> presenter = new JournalsPresenter<Car>(journal, new CarJournal(journal.Grid, _contractorID));

            journal.ShowDialog();

            if (presenter.Info != null)
            {
                CarModel car = (CarModel)presenter.Info;
                _carID = car.ID;
                View.Car = GetCarText(car.Model.Name, car.VIN);
            }
        }

        private void ClearContactPerson()
        {
            _powerOfAttorneyID = null;
            _contractPersonID = null;
            View.ContactPerson = string.Concat("выбрать");
            View.PowerOfAttorney = string.Concat("довереность");
            View.EnabledPowerOfAttorney = false;
        }

        private async Task AddOption()
        {
            bool verif = await VerificationSaved();

            if(verif)
                await _optionsCustomerJournal.AddRecord();
        }

        private async Task DeleteOption()
        {
            await _optionsCustomerJournal.DeleteRecord();
        }

        private async Task AddReason()
        {
            bool verif = await VerificationSaved();

            if (verif)
            {
                await _reasonsCustomerJournal.AddRecord();
                await CalculateSum();
            }
        }

        private async Task EditReason()
        {
            await _reasonsCustomerJournal.EditRecord();
            await CalculateSum();
        }

        private async Task DeleteReason()
        {
            await _reasonsCustomerJournal.DeleteRecord();
            await CalculateSum();
        }

        private void SelectionPowerOfAttorney()
        {
            JournalsForm journal = new JournalsForm();

            PowerOfAttorneyJournal powerOfAttorney = new PowerOfAttorneyJournal(journal.Grid, (Guid)_contractPersonID);

            JournalsPresenter<PowerOfAttorney> presenter = new JournalsPresenter<PowerOfAttorney>(journal, powerOfAttorney);

            journal.ShowDialog();

            if (presenter.Info != null)
            {
                PowerOfAttorneyModel power = (PowerOfAttorneyModel)presenter.Info;
                _powerOfAttorneyID = power.ID;
                View.PowerOfAttorney = GetPowerOfAttorneyText(power.Number, power.Date);
            }
        }

        private void SelectionContactPerson()
        {
            JournalsForm journal = new JournalsForm();

            JournalsPresenter<ContactPerson> presenter = new JournalsPresenter<ContactPerson>(journal, new ContactPersonJournal(journal.Grid, _contractorID));

            journal.ShowDialog();

            if (presenter.Info != null)
            {
                ContactPersonModel contact = (ContactPersonModel)presenter.Info;

                _contractPersonID = contact.ID;
                View.ContactPerson = contact.FFP;
                View.EnabledPowerOfAttorney = true;
            }
        }

        private void SelectionContractor()
        {
            JournalsForm journal = new JournalsForm();
            
            JournalsPresenter<Contractor> presenter = new JournalsPresenter<Contractor>(journal, new ContractorJournal(journal.Grid));

            journal.ShowDialog();

            if (presenter.Info != null)
            {
                ContractorModel contractor = (ContractorModel)presenter.Info;
                _contractorID = contractor.ID;
                View.Contractor = contractor.ShortName;
                View.EnabledContactPerson = true;
                View.EnabledCar = true;
            }
        }

        private void SelectionResponsible()
        {
            JournalsForm journal = new JournalsForm();
            
            JournalsPresenter<Employee> presenter = new JournalsPresenter<Employee>(journal, new EmployeeJournal(journal.Grid));

            journal.ShowDialog();

            if (presenter.Info != null)
            {
                EmployeeModel employee = (EmployeeModel)presenter.Info;

                _responsibleID = employee.ID;
                View.Responsible = employee.FFP;
            }
        }

        private async Task CalculateSum()
        {
            try
            {

                using (var context = new DbSSContext())
                {
                    decimal? sum  = await context.ReasonCustomer.SumAsync(rc =>


                        (rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)) == null ? 0

                        : rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)))


                        +


                        (rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)) == null ? 0


                        : rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)))
                        
                        );

                    View.Sum = sum?.ToString();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
        
        
        protected override async Task SaveAsync()
        {
            try
            {
                var typeRepair = View.TypeRepair;
                var number = View.Number;
                var date = View.Date;
                var firstControlTime = View.FirstControlTime;
                var secondControlTime = View.SecondControlTime;
                var readiness = View.Readiness;
                var extradition = View.Extradition;
                var revealed = View.Revealed;
                var recommendations = View.Recommendations;


                if (_contractorID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали контрагента!");
                if (_carID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали автомобиль!");
                if (_contractPersonID != null && _powerOfAttorneyID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали доверености контактного лица!");
                if (string.IsNullOrWhiteSpace(typeRepair))
                    throw new ArgumentNullException(null, "Вы не выбрали тип ремонта!");
                if(_responsibleID == null)
                    throw new ArgumentNullException(null, "Вы не выбрали ответственное лицо!");


                using (var context = new DbSSContext())
                {
                    
                    if (Identifier != null)
                    {
                        await context.Application.Where(a => a.Number.Equals(number)).UpdateAsync(a => new ApplicationModel
                        {
                            Date = date,
                            FirstControlTime = firstControlTime,
                            SecondControlTime = secondControlTime,
                            Readiness = readiness,
                            Extradition = extradition,
                            Revealed = GetNullValue(revealed),
                            Recommendations = GetNullValue(recommendations),
                            Type = typeRepair,
                            ID_employee = (Guid)_responsibleID,
                            ID_car = (Guid)_carID,
                            ID_powerOfAttorney = _powerOfAttorneyID
                        });
                    }
                    else
                    {
                        ApplicationModel insertApplicationInfo = new ApplicationModel
                        {
                            Number = number,
                            Date = date,
                            FirstControlTime = firstControlTime,
                            SecondControlTime = secondControlTime,
                            Readiness = readiness,
                            Extradition = extradition,
                            Revealed = GetNullValue(revealed),
                            Recommendations = GetNullValue(recommendations),
                            Type = typeRepair,
                            ID_employee = (Guid)_responsibleID,
                            ID_car = (Guid)_carID,
                            ID_powerOfAttorney = _powerOfAttorneyID
                        };


                        context.Application.Add(insertApplicationInfo);

                        await context.SaveChangesAsync();

                        Identifier = insertApplicationInfo.Number;
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
