using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using ServiceStation.InterfacesView;

namespace ServiceStation.Forms
{
    internal partial class MainForm : Form, IMainView
    {
        public event ActionAsync Loading;


        public event Action OutputJopTicket;
        public event Action OutputCertificateCompletion;
        public event Action OutputAcceptanceTransferOwnershipCertificate;


        public event Filter SeachEmployee;
        public event Filter SeachWorkingHour;
        public event Filter SeachUnit;
        public event Filter SeachNomenclature;
        public event Filter SeachOption;
        public event Filter SeachReason;
        public event Filter SeachMark;
        public event Filter SeachModel;
        public event Filter SeachContractor;
        public event Filter SeachApplication;
        

        public event ActionAsync UpdateEmployee;
        public event ActionAsync UpdateWorkingHour;
        public event ActionAsync UpdateUnit;
        public event ActionAsync UpdateNomenclature;
        public event ActionAsync UpdateOption;
        public event ActionAsync UpdateReason;
        public event ActionAsync UpdateMark;
        public event ActionAsync UpdateModel;
        public event ActionAsync UpdateContractor;
        public event ActionAsync UpdateApplication;


        public event ActionAsync AddEmployee;
        public event ActionAsync AddWorkingHour;
        public event ActionAsync AddUnit;
        public event ActionAsync AddNomenclature;
        public event ActionAsync AddOption;
        public event ActionAsync AddReason;
        public event ActionAsync AddMark;
        public event ActionAsync AddModel;
        public event ActionAsync AddContractor;
        public event ActionAsync AddApplication;


        public event ActionAsync EditEmployee;
        public event ActionAsync EditWorkingHour;
        public event ActionAsync EditUnit;
        public event ActionAsync EditNomenclature;
        public event ActionAsync EditOption;
        public event ActionAsync EditReason;
        public event ActionAsync EditMark;
        public event ActionAsync EditModel;
        public event ActionAsync EditContractor;
        public event ActionAsync EditApplication;


        public event ActionAsync DeleteEmployee;
        public event ActionAsync DeleteWorkingHour;
        public event ActionAsync DeleteUnit;
        public event ActionAsync DeleteNomenclature;
        public event ActionAsync DeleteOption;
        public event ActionAsync DeleteReason;
        public event ActionAsync DeleteMark;
        public event ActionAsync DeleteModel;
        public event ActionAsync DeleteContractor;
        public event ActionAsync DeleteApplication;

        internal MainForm()
        {
            InitializeComponent();

            main.B_Setting.Click += B_Setting_Click;

            main.LBI_Application.MouseLeftButtonUp += TSB_UpdateApplication_Click;
            main.LBI_Contractor.MouseLeftButtonUp += TSB_UpdateContractor_Click;
            main.LBI_Model.MouseLeftButtonUp += TSB_UpdateModel_Click;
            main.LBI_Mark.MouseLeftButtonUp += TSB_UpdateMark_Click;
            main.LBI_Reason.MouseLeftButtonUp += TSB_UpdateReason_Click;
            main.LBI_Option.MouseLeftButtonUp += TSB_UpdateOption_Click;
            main.LBI_Nomenclature.MouseLeftButtonUp += TSB_UpdateNomenclature_Click;
            main.LBI_Unit.MouseLeftButtonUp += TSB_UpdateUnit_Click;
            main.LBI_WorkingHour.MouseLeftButtonUp += TSB_UpdateWorkingHour_Click;


            main.TSB_UpdateApplication.Click += TSB_UpdateApplication_Click;
            main.TSB_UpdateContractor.Click += TSB_UpdateContractor_Click;
            main.TSB_UpdateModel.Click += TSB_UpdateModel_Click;
            main.TSB_UpdateMark.Click += TSB_UpdateMark_Click;
            main.TSB_UpdateReason.Click += TSB_UpdateReason_Click;
            main.TSB_UpdateOption.Click += TSB_UpdateOption_Click;
            main.TSB_UpdateNomenclature.Click += TSB_UpdateNomenclature_Click;
            main.TSB_UpdateUnit.Click += TSB_UpdateUnit_Click;
            main.TSB_UpdateWorkingHour.Click += TSB_UpdateWorkingHour_Click;
            main.TSB_UpdateEmployee.Click += TSB_UpdateUser_Click;


            main.TSB_AddApplication.Click += TSB_AddApplication_Click;
            main.TSB_AddContractor.Click += TSB_AddContractor_Click;
            main.TSB_AddModel.Click += TSB_AddModel_Click;
            main.TSB_AddMark.Click += TSB_AddMark_Click;
            main.TSB_AddReason.Click += TSB_AddReason_Click;
            main.TSB_AddOption.Click += TSB_AddOption_Click;
            main.TSB_AddNomenclature.Click += TSB_AddNomenclature_Click;
            main.TSB_AddUnit.Click += TSB_AddUnit_Click;
            main.TSB_AddWorkingHour.Click += TSB_AddWorkingHour_Click;
            main.TSB_AddEmployee.Click += TSB_AddUser_Click;


            main.TSB_EditApplication.Click += TSB_EditApplication_Click;
            main.TSB_EditContractor.Click += TSB_EditContractor_Click;
            main.TSB_EditModel.Click += TSB_EditModel_Click;
            main.TSB_EditMark.Click += TSB_EditMark_Click;
            main.TSB_EditReason.Click += TSB_EditReason_Click;
            main.TSB_EditOption.Click += TSB_EditOption_Click;
            main.TSB_EditNomenclature.Click += TSB_EditNomenclature_Click;
            main.TSB_EditUnit.Click += TSB_EditUnit_Click;
            main.TSB_EditWorkingHour.Click += TSB_EditWorkingHour_Click;
            main.TSB_EditEmployee.Click += TSB_EditUser_Click;


            main.DGV_Apptications.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditApplication_Click(s, e); };
            main.DGV_Contractors.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditContractor_Click(s, e); };
            main.DGV_Models.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditModel_Click(s, e); }; ;
            main.DGV_Marks.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditMark_Click(s, e); };
            main.DGV_Reasons.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditReason_Click(s, e); };
            main.DGV_Options.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditOption_Click(s, e); };
            main.DGV_Nomenclatures.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditNomenclature_Click(s, e); };
            main.DGV_Unit.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditUnit_Click(s, e); };
            main.DGV_WorkingHours.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditWorkingHour_Click(s, e); };
            main.DGV_Employees.MouseDoubleClick += (s, e) => { if (e.Button == MouseButtons.Left) TSB_EditUser_Click(s, e); };



            main.TSB_DeleteApplication.Click += TSB_DeleteApplication_Click;
            main.TSB_DeleteContractor.Click += TSB_DeleteContractor_Click;
            main.TSB_DeleteModel.Click += TSB_DeleteModel_Click;
            main.TSB_DeleteMark.Click += TSB_DeleteMark_Click;
            main.TSB_DeleteReason.Click += TSB_DeleteReason_Click;
            main.TSB_DeleteOption.Click += TSB_DeleteOption_Click;
            main.TSB_DeleteNomenclature.Click += TSB_DeleteNomenclature_Click;
            main.TSB_DeleteUnit.Click += TSB_DeleteUnit_Click;
            main.TSB_DeleteWorkingHour.Click += TSB_DeleteWorkingHour_Click;
            main.TSB_DeleteEmployee.Click += TSB_DeleteUser_Click;


            main.TSTB_SeachApplication.TextChanged += TSTB_SeachApplication_TextChanged;
            main.TSTB_SeachContractor.TextChanged += TSTB_SeachContractor_TextChanged;
            main.TSTB_SeachModel.TextChanged += TSTB_SeachModel_TextChanged;
            main.TSTB_SeachMark.TextChanged += TSTB_SeachMark_TextChanged;
            main.TSTB_SeachReason.TextChanged += TSTB_SeachReason_TextChanged;
            main.TSTB_SeachOption.TextChanged += TSTB_SeachOption_TextChanged;
            main.TSTB_SeachNomenclature.TextChanged += TSTB_SeachNomenclature_TextChanged;
            main.TSTB_SeachUnit.TextChanged += TSTB_SeachUnit_TextChanged;
            main.TSTB_SeachWorkingHour.TextChanged += TSTB_SeachWorkingHour_TextChanged;
            main.TSTB_SeachEmployee.TextChanged += TSTB_SeachUser_TextChanged;


            main.TSMI_PrintAcceptanceTransferOwnershipCertificate.Click += TSMI_PrintAcceptanceTransferOwnershipCertificate_Click;
            main.TSMI_PrintCertificateCompletion.Click += TSMI_PrintCertificateCompletion_Click;
            main.TSMI_PrintJopTicket.Click += TSMI_PrintJopTicket_Click;
                        
        }
        
        public Visibility SettingVisibility { set { main.B_Setting.Visibility = value; } }

        public string Title { set { this.Title = value; } }

        public MainControl.MainControl Main { get { return main; } }

        private void TSMI_PrintJopTicket_Click(object sender, EventArgs e)
        {
            OutputJopTicket?.Invoke();
        }

        private void TSMI_PrintCertificateCompletion_Click(object sender, EventArgs e)
        {
            OutputCertificateCompletion?.Invoke();
        }

        private void TSMI_PrintAcceptanceTransferOwnershipCertificate_Click(object sender, EventArgs e)
        {
            OutputAcceptanceTransferOwnershipCertificate?.Invoke();
        }
        
        private void TSTB_SeachUser_TextChanged(object sender, EventArgs e)
        {
            SeachEmployee?.Invoke(main.TSTB_SeachEmployee.Text);
        }

        private void TSTB_SeachWorkingHour_TextChanged(object sender, EventArgs e)
        {
            SeachWorkingHour?.Invoke(main.TSTB_SeachWorkingHour.Text);
        }

        private void TSTB_SeachUnit_TextChanged(object sender, EventArgs e)
        {
            SeachUnit?.Invoke(main.TSTB_SeachUnit.Text);
        }

        private void TSTB_SeachNomenclature_TextChanged(object sender, EventArgs e)
        {
            SeachNomenclature?.Invoke(main.TSTB_SeachNomenclature.Text);
        }

        private void TSTB_SeachOption_TextChanged(object sender, EventArgs e)
        {
            SeachOption?.Invoke(main.TSTB_SeachOption.Text);
        }

        private void TSTB_SeachReason_TextChanged(object sender, EventArgs e)
        {
            SeachReason?.Invoke(main.TSTB_SeachReason.Text);
        }

        private void TSTB_SeachMark_TextChanged(object sender, EventArgs e)
        {
            SeachMark?.Invoke(main.TSTB_SeachMark.Text);
        }

        private void TSTB_SeachModel_TextChanged(object sender, EventArgs e)
        {
            SeachModel?.Invoke(main.TSTB_SeachModel.Text);
        }

        private void TSTB_SeachContractor_TextChanged(object sender, EventArgs e)
        {
            SeachContractor?.Invoke(main.TSTB_SeachContractor.Text);
        }

        private void TSTB_SeachApplication_TextChanged(object sender, EventArgs e)
        {
            SeachApplication?.Invoke(main.TSTB_SeachApplication.Text);
        }

        private async void TSB_UpdateUser_Click(object sender, EventArgs e)
        {
            await UpdateEmployee?.Invoke();
        }

        private async void TSB_UpdateWorkingHour_Click(object sender, EventArgs e)
        {
            await UpdateWorkingHour?.Invoke();
        }

        private async void TSB_UpdateUnit_Click(object sender, EventArgs e)
        {
            await UpdateUnit?.Invoke();
        }

        private async void TSB_UpdateNomenclature_Click(object sender, EventArgs e)
        {
            await UpdateNomenclature?.Invoke();
        }

        private async void TSB_UpdateOption_Click(object sender, EventArgs e)
        {
            await UpdateOption?.Invoke();
        }

        private async void TSB_UpdateReason_Click(object sender, EventArgs e)
        {
            await UpdateReason?.Invoke();
        }

        private async void TSB_UpdateMark_Click(object sender, EventArgs e)
        {
            await UpdateMark?.Invoke();
        }

        private async void TSB_UpdateModel_Click(object sender, EventArgs e)
        {
            await UpdateModel?.Invoke();
        }

        private async void TSB_UpdateContractor_Click(object sender, EventArgs e)
        {
            await UpdateContractor?.Invoke();
        }

        private async void TSB_UpdateApplication_Click(object sender, EventArgs e)
        {
            await UpdateApplication?.Invoke();
        }

        private async void TSB_DeleteUser_Click(object sender, EventArgs e)
        {
            await DeleteEmployee?.Invoke();
        }

        private async void TSB_DeleteWorkingHour_Click(object sender, EventArgs e)
        {
            await DeleteWorkingHour?.Invoke();
        }

        private async void TSB_DeleteUnit_Click(object sender, EventArgs e)
        {
            await DeleteUnit?.Invoke();
        }

        private async void TSB_DeleteNomenclature_Click(object sender, EventArgs e)
        {
            await DeleteNomenclature?.Invoke();
        }

        private async void TSB_DeleteOption_Click(object sender, EventArgs e)
        {
            await DeleteOption?.Invoke();
        }

        private async void TSB_DeleteReason_Click(object sender, EventArgs e)
        {
            await DeleteReason?.Invoke();
        }

        private async void TSB_DeleteMark_Click(object sender, EventArgs e)
        {
            await DeleteMark?.Invoke();
        }

        private async void TSB_DeleteModel_Click(object sender, EventArgs e)
        {
            await DeleteModel?.Invoke();
        }

        private async void TSB_DeleteContractor_Click(object sender, EventArgs e)
        {
            await DeleteContractor?.Invoke();
        }

        private async void TSB_DeleteApplication_Click(object sender, EventArgs e)
        {
            await DeleteApplication?.Invoke();
        }

        private async void TSB_EditUser_Click(object sender, EventArgs e)
        {
            await EditEmployee?.Invoke();
        }

        private async void TSB_EditWorkingHour_Click(object sender, EventArgs e)
        {
            await EditWorkingHour?.Invoke();
        }

        private async void TSB_EditUnit_Click(object sender, EventArgs e)
        {
            await EditUnit?.Invoke();
        }

        private async void TSB_EditNomenclature_Click(object sender, EventArgs e)
        {
            await EditNomenclature?.Invoke();
        }

        private async void TSB_EditOption_Click(object sender, EventArgs e)
        {
            await EditOption?.Invoke();
        }

        private async void TSB_EditReason_Click(object sender, EventArgs e)
        {
            await EditReason?.Invoke();
        }

        private async void TSB_EditMark_Click(object sender, EventArgs e)
        {
            await EditMark?.Invoke();
        }

        private async void TSB_EditModel_Click(object sender, EventArgs e)
        {
            await EditModel?.Invoke();
        }

        private async void TSB_EditContractor_Click(object sender, EventArgs e)
        {
            await EditContractor?.Invoke();
        }

        private async void TSB_EditApplication_Click(object sender, EventArgs e)
        {
            await EditApplication?.Invoke();
        }

        private async void TSB_AddUser_Click(object sender, EventArgs e)
        {
            await AddEmployee?.Invoke();
        }

        private async void TSB_AddWorkingHour_Click(object sender, EventArgs e)
        {
            await AddWorkingHour?.Invoke();
        }

        private async void TSB_AddUnit_Click(object sender, EventArgs e)
        {
            await AddUnit?.Invoke();
        }

        private async void TSB_AddNomenclature_Click(object sender, EventArgs e)
        {
            await AddNomenclature?.Invoke();
        }

        private async void TSB_AddOption_Click(object sender, EventArgs e)
        {
            await AddOption?.Invoke();
        }

        private async void TSB_AddReason_Click(object sender, EventArgs e)
        {
            await AddReason?.Invoke();
        }

        private async void TSB_AddMark_Click(object sender, EventArgs e)
        {
            await AddMark?.Invoke();
        }

        private async void TSB_AddModel_Click(object sender, EventArgs e)
        {
            await AddModel?.Invoke();
        }

        private async void TSB_AddContractor_Click(object sender, EventArgs e)
        {
            await AddContractor?.Invoke();
        }

        private async void TSB_AddApplication_Click(object sender, EventArgs e)
        {
            await AddApplication?.Invoke();
        }

        private async void B_Setting_Click(object sender, RoutedEventArgs e)
        {
            await UpdateEmployee.Invoke();
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            Main.DGV_Apptications.Focus();
            main.TI_Setting.IsVisibleChanged += TI_Setting_IsVisibleChanged;
        }

        private void TI_Setting_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(main.TI_Setting.Visibility == Visibility.Visible)
            {
                main.P_AgreementConditions.Inlines.Clear();
                main.P_AgreementConditions.Inlines.Add(Properties.Settings.Default.AgreementConditions);

                main.P_TermsPurchaseMaterials.Inlines.Clear();
                main.P_TermsPurchaseMaterials.Inlines.Add(Properties.Settings.Default.TermsPurchaseMaterials);

                main.P_Guarantee.Inlines.Clear();
                main.P_Guarantee.Inlines.Add(Properties.Settings.Default.Guarantee);
            }
            else
            {
                Properties.Settings.Default.AgreementConditions = new TextRange(main.RTB_AgreementConditions.Document.ContentStart,                                                                                                     main.RTB_AgreementConditions.Document.ContentEnd).Text;

                Properties.Settings.Default.TermsPurchaseMaterials = new TextRange(main.RTB_TermsPurchaseMaterials.Document.ContentStart,                                                                                                      main.RTB_TermsPurchaseMaterials.Document.ContentEnd).Text;

                Properties.Settings.Default.Guarantee = new TextRange(main.RTB_Guarantee.Document.ContentStart, main.RTB_Guarantee.Document.ContentEnd).Text;


                Properties.Settings.Default.Save();
            }
        }
    }
}
