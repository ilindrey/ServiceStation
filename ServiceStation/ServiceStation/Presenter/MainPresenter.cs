using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows;
using ServiceStation.GridView;
using ServiceStation.InterfacesView;
using ServiceStation.Model;

namespace ServiceStation.Presenter
{
    internal class MainPresenter : BasePresenter<IMainView>
    {
        private EmployeeJournal _usersJournal;
        private OptionJournal _optionsJournal;
        private ApplicationJournal _applicationsJournal;
        private ReasonJournal _reasonsJournal;
        private ContractorJournal _contractorsJournal;
        private MarkJournal _marksJournal;
        private ModelJournal _modelsJournal;
        private NomenclatureJournal _nomenclaturesJournal;
        private UnitJournal _unitsJournal;
        private WorkingHourJournal _workingHoursJournal;
        

        public MainPresenter(IMainView view, bool administrator) : base(view)
        {
            if (administrator)
                View.SettingVisibility = Visibility.Visible;
            else
                View.SettingVisibility = Visibility.Collapsed;
        }

        protected override void SubscribeEvent()
        {
            View.Loading += View_Loading; 


            View.OutputJopTicket += View_OutputJopTicket;
            View.OutputCertificateCompletion += View_OutputCertificateCompletion;
            View.OutputAcceptanceTransferOwnershipCertificate += View_OutputAcceptanceTransferOwnershipCertificate;


            View.SeachEmployee += a => _usersJournal.Filter(a);
            View.SeachWorkingHour += a => _workingHoursJournal.Filter(a);
            View.SeachUnit += a => _unitsJournal.Filter(a);
            View.SeachNomenclature += a => _nomenclaturesJournal.Filter(a);
            View.SeachOption += a => _optionsJournal.Filter(a);
            View.SeachReason += a => _reasonsJournal.Filter(a);
            View.SeachMark += a => _marksJournal.Filter(a);
            View.SeachModel += a => _modelsJournal.Filter(a);
            View.SeachContractor += a => _contractorsJournal.Filter(a);
            View.SeachApplication += a => _applicationsJournal.Filter(a);


            View.UpdateEmployee += async () => await _usersJournal.Update();
            View.UpdateWorkingHour += async () => await _workingHoursJournal.Update();
            View.UpdateUnit += async () => await _unitsJournal.Update();
            View.UpdateNomenclature += async () => await _nomenclaturesJournal.Update();
            View.UpdateOption += async () => await _optionsJournal.Update();
            View.UpdateReason += async () => await _reasonsJournal.Update();
            View.UpdateMark += async () => await _marksJournal.Update();
            View.UpdateModel += async () => await _modelsJournal.Update();
            View.UpdateContractor += async () => await _contractorsJournal.Update();
            View.UpdateApplication += async () => await _applicationsJournal.Update();


            View.AddEmployee += async () => await _usersJournal.AddRecord();
            View.AddWorkingHour += async () => await _workingHoursJournal.AddRecord();
            View.AddUnit += async () => await _unitsJournal.AddRecord();
            View.AddNomenclature += async () => await _nomenclaturesJournal.AddRecord();
            View.AddOption += async () => await _optionsJournal.AddRecord();
            View.AddReason += async () => await _reasonsJournal.AddRecord();
            View.AddMark += async () => await _marksJournal.AddRecord();
            View.AddModel += async () => await _modelsJournal.AddRecord();
            View.AddContractor += async () => await _contractorsJournal.AddRecord();
            View.AddApplication += async () => await _applicationsJournal.AddRecord();


            View.EditEmployee += async () => await _usersJournal.EditRecord();
            View.EditWorkingHour += async () => await _workingHoursJournal.EditRecord();
            View.EditUnit += async () => await _unitsJournal.EditRecord();
            View.EditNomenclature += async () => await _nomenclaturesJournal.EditRecord();
            View.EditOption += async () => await _optionsJournal.EditRecord();
            View.EditReason += async () => await _reasonsJournal.EditRecord();
            View.EditMark += async () => await _marksJournal.EditRecord();
            View.EditModel += async () => await _modelsJournal.EditRecord();
            View.EditContractor += async () => await _contractorsJournal.EditRecord();
            View.EditApplication += async () => await _applicationsJournal.EditRecord();


            View.DeleteEmployee += async () => await _usersJournal.DeleteRecord();
            View.DeleteWorkingHour += async () => await _workingHoursJournal.DeleteRecord();
            View.DeleteUnit += async () => await _unitsJournal.DeleteRecord();
            View.DeleteNomenclature += async () => await _nomenclaturesJournal.DeleteRecord();
            View.DeleteOption += async () => await _optionsJournal.DeleteRecord();
            View.DeleteReason += async () => await _reasonsJournal.DeleteRecord();
            View.DeleteMark += async () => await _marksJournal.DeleteRecord();
            View.DeleteModel += async () => await _modelsJournal.DeleteRecord();
            View.DeleteContractor += async () => await _contractorsJournal.DeleteRecord();
            View.DeleteApplication += async () => await _applicationsJournal.DeleteRecord();
        }
        
        private void View_OutputAcceptanceTransferOwnershipCertificate()
        {
            _applicationsJournal.OutputAcceptanceTransferOwnershipCertificate();
        }

        private void View_OutputCertificateCompletion()
        {
            _applicationsJournal.OutputCertificateCompletion();
        }

        private void View_OutputJopTicket()
        {
            _applicationsJournal.OutputJopTicket();
        }

        private async Task View_Loading()
        {
            try
            {
                var main = View.Main;

                _usersJournal = new EmployeeJournal(main.DGV_Employees, true);
                _workingHoursJournal = new WorkingHourJournal(main.DGV_WorkingHours);
                _unitsJournal = new UnitJournal(main.DGV_Unit);
                _nomenclaturesJournal = new NomenclatureJournal(main.DGV_Nomenclatures);
                _optionsJournal = new OptionJournal(main.DGV_Options);
                _reasonsJournal = new ReasonJournal(main.DGV_Reasons);
                _marksJournal = new MarkJournal(main.DGV_Marks);
                _modelsJournal = new ModelJournal(main.DGV_Models);
                _contractorsJournal = new ContractorJournal(main.DGV_Contractors);
                _applicationsJournal = new ApplicationJournal(main.DGV_Apptications);

                using (var context = new DbSSContext())
                {
                    int countViewСontractor = await context.ViewСontractor.CountAsync();

                    int countTypeManifestation = await context.TypeManifestation.CountAsync();

                    int countTypeRepair = await context.TypeRepair.CountAsync();

                    var countTypeNomenclature = await context.TypeNomenclature.CountAsync();

                    if (countViewСontractor == 0)
                    {
                        List<ViewСontractorModel> view = new List<ViewСontractorModel>()
                        {
                            new ViewСontractorModel { View = "Юридическое лицо" },
                            new ViewСontractorModel { View = "Физическое лицо" }
                        };
                        context.ViewСontractor.AddRange(view);
                    }

                    if (countTypeManifestation == 0)
                    {
                        List<TypeManifestationModel> type = new List<TypeManifestationModel>()
                        {
                            new TypeManifestationModel { Type = "Внешнее" },
                            new TypeManifestationModel { Type = "Втуреннее" }
                        };
                        context.TypeManifestation.AddRange(type);
                    }

                    if (countTypeRepair == 0)
                    {

                        List<TypeRepairModel> type = new List<TypeRepairModel>()
                        {
                            new TypeRepairModel { Type = "Гарантийный" },
                            new TypeRepairModel { Type = "Текущий" }
                        };
                        context.TypeRepair.AddRange(type);
                    }

                    if (countTypeNomenclature == 0)
                    {
                        List<TypeNomenclatureModel> type = new List<TypeNomenclatureModel>()
                        {
                            new TypeNomenclatureModel { Type = "Товар" },
                            new TypeNomenclatureModel { Type = "Работа" }
                        };
                        context.TypeNomenclature.AddRange(type);
                    }

                    await context.SaveChangesAsync();
                }
                await _applicationsJournal.Update();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
