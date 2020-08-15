using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace MainControl
{
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : System.Windows.Controls.UserControl
    {
        // Контролы для заявки
        public ToolStripContainer TSC_Apptication { get; set; }
        public ToolStrip TS_Application { get; set; }
        public DataGridView DGV_Apptications { get; set; }
        public ToolStripButton TSB_AddApplication { get; set; }
        public ToolStripButton TSB_EditApplication { get; set; }
        public ToolStripButton TSB_DeleteApplication { get; set; }
        public ToolStripButton TSB_UpdateApplication { get; set; }
        public ToolStripLabel TSL_SeachApplication { get; set; }
        public ToolStripDropDownButton TSDDB_PrintApplication { get; set; }
        public ToolStripTextBox TSTB_SeachApplication { get; set; }
        public ToolStripMenuItem TSMI_PrintAcceptanceTransferOwnershipCertificate { get; set; }
        public ToolStripMenuItem TSMI_PrintJopTicket { get; set; }
        public ToolStripMenuItem TSMI_PrintCertificateCompletion { get; set; }


        // Контролы для контрагент
        public ToolStripContainer TSC_Contractor { get; set; }
        public ToolStrip TS_Contractor { get; set; }
        public DataGridView DGV_Contractors { get; set; }
        public ToolStripButton TSB_AddContractor { get; set; }
        public ToolStripButton TSB_EditContractor { get; set; }
        public ToolStripButton TSB_DeleteContractor { get; set; }
        public ToolStripButton TSB_UpdateContractor { get; set; }
        public ToolStripLabel TSL_SeachContractor { get; set; }
        public ToolStripTextBox TSTB_SeachContractor { get; set; }


        // Контролы для модели
        public ToolStripContainer TSC_Model { get; set; }
        public ToolStrip TS_Model { get; set; }
        public DataGridView DGV_Models { get; set; }
        public ToolStripButton TSB_AddModel { get; set; }
        public ToolStripButton TSB_EditModel { get; set; }
        public ToolStripButton TSB_DeleteModel { get; set; }
        public ToolStripButton TSB_UpdateModel { get; set; }
        public ToolStripLabel TSL_SeachModel { get; set; }
        public ToolStripTextBox TSTB_SeachModel { get; set; }


        // Контролы для марки
        public ToolStripContainer TSC_Mark { get; set; }
        public ToolStrip TS_Mark { get; set; }
        public DataGridView DGV_Marks { get; set; }
        public ToolStripButton TSB_AddMark { get; set; }
        public ToolStripButton TSB_EditMark { get; set; }
        public ToolStripButton TSB_DeleteMark { get; set; }
        public ToolStripButton TSB_UpdateMark { get; set; }
        public ToolStripLabel TSL_SeachMark { get; set; }
        public ToolStripTextBox TSTB_SeachMark { get; set; }

        
        // Контролы для причин обращения
        public ToolStripContainer TSC_Reason { get; set; }
        public ToolStrip TS_Reason { get; set; }
        public DataGridView DGV_Reasons { get; set; }
        public ToolStripButton TSB_AddReason { get; set; }
        public ToolStripButton TSB_EditReason { get; set; }
        public ToolStripButton TSB_DeleteReason { get; set; }
        public ToolStripButton TSB_UpdateReason { get; set; }
        public ToolStripLabel TSL_SeachReason { get; set; }
        public ToolStripTextBox TSTB_SeachReason { get; set; }


        // Контролы для комплектаций
        public ToolStripContainer TSC_Option { get; set; }
        public ToolStrip TS_Option { get; set; }
        public DataGridView DGV_Options { get; set; }
        public ToolStripButton TSB_AddOption { get; set; }
        public ToolStripButton TSB_EditOption { get; set; }
        public ToolStripButton TSB_DeleteOption { get; set; }
        public ToolStripButton TSB_UpdateOption { get; set; }
        public ToolStripLabel TSL_SeachOption { get; set; }
        public ToolStripTextBox TSTB_SeachOption { get; set; }


        // Контролы для номенклатур
        public ToolStripContainer TSC_Nomenclature { get; set; }
        public ToolStrip TS_Nomenclature { get; set; }
        public DataGridView DGV_Nomenclatures { get; set; }
        public ToolStripButton TSB_AddNomenclature { get; set; }
        public ToolStripButton TSB_EditNomenclature { get; set; }
        public ToolStripButton TSB_DeleteNomenclature { get; set; }
        public ToolStripButton TSB_UpdateNomenclature { get; set; }
        public ToolStripLabel TSL_SeachNomenclature { get; set; }
        public ToolStripTextBox TSTB_SeachNomenclature { get; set; }


        // Контролы для едениц измерения
        public ToolStripContainer TSC_Unit { get; set; }
        public ToolStrip TS_Units { get; set; }
        public DataGridView DGV_Unit { get; set; }
        public ToolStripButton TSB_AddUnit { get; set; }
        public ToolStripButton TSB_EditUnit { get; set; }
        public ToolStripButton TSB_DeleteUnit { get; set; }
        public ToolStripButton TSB_UpdateUnit { get; set; }
        public ToolStripLabel TSL_SeachUnit { get; set; }
        public ToolStripTextBox TSTB_SeachUnit { get; set; }


        // Контролы для едениц измерения
        public ToolStripContainer TSC_WorkingHour { get; set; }
        public ToolStrip TS_WorkingHour { get; set; }
        public DataGridView DGV_WorkingHours { get; set; }
        public ToolStripButton TSB_AddWorkingHour { get; set; }
        public ToolStripButton TSB_EditWorkingHour { get; set; }
        public ToolStripButton TSB_DeleteWorkingHour { get; set; }
        public ToolStripButton TSB_UpdateWorkingHour { get; set; }
        public ToolStripLabel TSL_SeachWorkingHour { get; set; }
        public ToolStripTextBox TSTB_SeachWorkingHour { get; set; }


        // Контролы для пользователей системы
        public ToolStripContainer TSC_Employee { get; set; }
        public ToolStrip TS_Employee { get; set; }
        public DataGridView DGV_Employees { get; set; }
        public ToolStripButton TSB_AddEmployee { get; set; }
        public ToolStripButton TSB_EditEmployee { get; set; }
        public ToolStripButton TSB_DeleteEmployee { get; set; }
        public ToolStripButton TSB_UpdateEmployee { get; set; }
        public ToolStripLabel TSL_SeachEmployee { get; set; }
        public ToolStripTextBox TSTB_SeachEmployee { get; set; }

        public System.Windows.Controls.Button B_Setting { get { return btnSetting; } }
        
        /// <summary>
        /// условия заключения договора
        /// </summary>
        public System.Windows.Controls.RichTextBox RTB_AgreementConditions { get {return rtbAgreementConditions; } }
        public Paragraph P_AgreementConditions { get { return pAgreementConditions; } }

        /// <summary>
        /// Условия договора о покупке материалов
        /// </summary>
        public System.Windows.Controls.RichTextBox RTB_TermsPurchaseMaterials { get { return rtbTermsPurchaseMaterials; } }
        public Paragraph P_TermsPurchaseMaterials { get { return pTermsPurchaseMaterials; } }

        /// <summary>
        /// Условия гарантии
        /// </summary>
        public System.Windows.Controls.RichTextBox RTB_Guarantee { get { return rtbGuarantee; } }
        public Paragraph P_Guarantee { get { return pGuarantee; } }

        public ListBoxItem LBI_Application { get { return lbiApplication; } }
        public ListBoxItem LBI_Contractor { get { return lbiContractor; } }
        public ListBoxItem LBI_Mark { get { return lbiMark; } }
        public ListBoxItem LBI_Model { get { return lbiModel; } }
        public ListBoxItem LBI_Nomenclature { get { return lbiNomenclature; } }
        public ListBoxItem LBI_Option { get { return lbiOption; } }
        public ListBoxItem LBI_Reason { get { return lbiReason; } }
        public ListBoxItem LBI_Unit { get { return lbiUnit; } }
        public ListBoxItem LBI_WorkingHour { get { return lbiWorkingHour; } }


        public TabItem TI_Setting { get { return tiSetting; } }


        public MainControl()
        {
            InitializeComponent();

            CreateAppticationControls();

            TSC_Contractor = new ToolStripContainer();
            TS_Contractor = new ToolStrip();
            DGV_Contractors = new DataGridView();
            TSB_AddContractor = new ToolStripButton();
            TSB_EditContractor = new ToolStripButton();
            TSB_DeleteContractor = new ToolStripButton();
            TSB_UpdateContractor = new ToolStripButton();
            TSL_SeachContractor = new ToolStripLabel();
            TSTB_SeachContractor = new ToolStripTextBox();

            CreateControls(TSC_Contractor, TS_Contractor, DGV_Contractors, TSB_AddContractor, TSB_EditContractor, TSB_DeleteContractor, TSB_UpdateContractor, TSL_SeachContractor, TSTB_SeachContractor);

            wfhContractor.Child = TSC_Contractor;


            TSC_Model = new ToolStripContainer();
            TS_Model = new ToolStrip();
            DGV_Models = new DataGridView();
            TSB_AddModel = new ToolStripButton();
            TSB_EditModel = new ToolStripButton();
            TSB_DeleteModel = new ToolStripButton();
            TSB_UpdateModel = new ToolStripButton();
            TSL_SeachModel = new ToolStripLabel();
            TSTB_SeachModel = new ToolStripTextBox();

            CreateControls(TSC_Model, TS_Model, DGV_Models, TSB_AddModel, TSB_EditModel, TSB_DeleteModel, TSB_UpdateModel, TSL_SeachModel, TSTB_SeachModel);

            wfhModel.Child = TSC_Model;

            TSC_Mark = new ToolStripContainer();
            TS_Mark = new ToolStrip();
            DGV_Marks = new DataGridView();
            TSB_AddMark = new ToolStripButton();
            TSB_EditMark = new ToolStripButton();
            TSB_DeleteMark = new ToolStripButton();
            TSB_UpdateMark = new ToolStripButton();
            TSL_SeachMark = new ToolStripLabel();
            TSTB_SeachMark = new ToolStripTextBox();

            CreateControls(TSC_Mark, TS_Mark, DGV_Marks, TSB_AddMark, TSB_EditMark, TSB_DeleteMark, TSB_UpdateMark, TSL_SeachMark, TSTB_SeachMark);

            wfhMark.Child = TSC_Mark;


            TSC_Reason = new ToolStripContainer();
            TS_Reason = new ToolStrip();
            DGV_Reasons = new DataGridView();
            TSB_AddReason = new ToolStripButton();
            TSB_EditReason = new ToolStripButton();
            TSB_DeleteReason = new ToolStripButton();
            TSB_UpdateReason = new ToolStripButton();
            TSL_SeachReason = new ToolStripLabel();
            TSTB_SeachReason = new ToolStripTextBox();

            CreateControls(TSC_Reason, TS_Reason, DGV_Reasons, TSB_AddReason, TSB_EditReason, TSB_DeleteReason, TSB_UpdateReason, TSL_SeachReason, TSTB_SeachReason);

            wfhReason.Child = TSC_Reason;


            TSC_Option = new ToolStripContainer();
            TS_Option = new ToolStrip();
            DGV_Options = new DataGridView();
            TSB_AddOption = new ToolStripButton();
            TSB_EditOption = new ToolStripButton();
            TSB_DeleteOption = new ToolStripButton();
            TSB_UpdateOption = new ToolStripButton();
            TSL_SeachOption = new ToolStripLabel();
            TSTB_SeachOption = new ToolStripTextBox();

            CreateControls(TSC_Option, TS_Option, DGV_Options, TSB_AddOption, TSB_EditOption, TSB_DeleteOption, TSB_UpdateOption, TSL_SeachOption, TSTB_SeachOption);

            wfhOption.Child = TSC_Option;


            TSC_Nomenclature = new ToolStripContainer();
            TS_Nomenclature = new ToolStrip();
            DGV_Nomenclatures = new DataGridView();
            TSB_AddNomenclature = new ToolStripButton();
            TSB_EditNomenclature = new ToolStripButton();
            TSB_DeleteNomenclature = new ToolStripButton();
            TSB_UpdateNomenclature = new ToolStripButton();
            TSL_SeachNomenclature = new ToolStripLabel();
            TSTB_SeachNomenclature = new ToolStripTextBox();

            CreateControls(TSC_Nomenclature, TS_Nomenclature, DGV_Nomenclatures, TSB_AddNomenclature, TSB_EditNomenclature, TSB_DeleteNomenclature, TSB_UpdateNomenclature, TSL_SeachNomenclature, TSTB_SeachNomenclature);

            wfhNomenclature.Child = TSC_Nomenclature;


            TSC_Unit = new ToolStripContainer();
            TS_Units = new ToolStrip();
            DGV_Unit = new DataGridView();
            TSB_AddUnit = new ToolStripButton();
            TSB_EditUnit = new ToolStripButton();
            TSB_DeleteUnit = new ToolStripButton();
            TSB_UpdateUnit = new ToolStripButton();
            TSL_SeachUnit = new ToolStripLabel();
            TSTB_SeachUnit = new ToolStripTextBox();

            CreateControls(TSC_Unit, TS_Units, DGV_Unit, TSB_AddUnit, TSB_EditUnit, TSB_DeleteUnit, TSB_UpdateUnit, TSL_SeachUnit, TSTB_SeachUnit);

            wfhUnit.Child = TSC_Unit;


            TSC_WorkingHour = new ToolStripContainer();
            TS_WorkingHour = new ToolStrip();
            DGV_WorkingHours = new DataGridView();
            TSB_AddWorkingHour = new ToolStripButton();
            TSB_EditWorkingHour = new ToolStripButton();
            TSB_DeleteWorkingHour = new ToolStripButton();
            TSB_UpdateWorkingHour = new ToolStripButton();
            TSL_SeachWorkingHour = new ToolStripLabel();
            TSTB_SeachWorkingHour = new ToolStripTextBox();

            CreateControls(TSC_WorkingHour, TS_WorkingHour, DGV_WorkingHours, TSB_AddWorkingHour, TSB_EditWorkingHour, TSB_DeleteWorkingHour, TSB_UpdateWorkingHour, TSL_SeachWorkingHour, TSTB_SeachWorkingHour);

            wfhWorkingHour.Child = TSC_WorkingHour;


            TSC_Employee = new ToolStripContainer();
            TS_Employee = new ToolStrip();
            DGV_Employees = new DataGridView();
            TSB_AddEmployee = new ToolStripButton();
            TSB_EditEmployee = new ToolStripButton();
            TSB_DeleteEmployee = new ToolStripButton();
            TSB_UpdateEmployee = new ToolStripButton();
            TSL_SeachEmployee = new ToolStripLabel();
            TSTB_SeachEmployee = new ToolStripTextBox();

            CreateControls(TSC_Employee, TS_Employee, DGV_Employees, TSB_AddEmployee, TSB_EditEmployee, TSB_DeleteEmployee, TSB_UpdateEmployee, TSL_SeachEmployee, TSTB_SeachEmployee);

            wfhSetting.Child = TSC_Employee;


            btnCloseApplication.Click += (s, e) =>
            {
                ClosingTabPage(ref tiApplication);
            };
            btnCloseContractor.Click += (s, e) =>
            {
                ClosingTabPage(ref tiContractor);
            };
            btnCloseModel.Click += (s, e) =>
            {
                ClosingTabPage(ref tiModel);
            };
            btnCloseMark.Click += (s, e) =>
            {
                ClosingTabPage(ref tiMark);
            };
            btnCloseReason.Click += (s, e) =>
            {
                ClosingTabPage(ref tiReason);
            };
            btnCloseOption.Click += (s, e) =>
            {
                ClosingTabPage(ref tiOption);
            };
            btnCloseNomenclature.Click += (s, e) =>
            {
                ClosingTabPage(ref tiNomenclature);
            };
            btnCloseUnit.Click += (s, e) =>
            {
                ClosingTabPage(ref tiUnit);
            };
            btnCloseWorkingHour.Click += (s, e) =>
            {
                ClosingTabPage(ref tiWorkingHour);
            };
            btnCloseSetting.Click += (s, e) =>
            {
                ClosingTabPage(ref tiSetting);
            };

            lbiApplication.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiApplication);
            lbiContractor.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiContractor);
            lbiModel.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiModel);
            lbiMark.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiMark);
            lbiReason.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiReason);
            lbiOption.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiOption);
            lbiNomenclature.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiNomenclature);
            lbiUnit.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiUnit);
            lbiWorkingHour.MouseLeftButtonUp += (s, e) => VisibilityTabPage(ref tiWorkingHour);

            btnSetting.Click += (s, e) => VisibilityTabPage(ref tiSetting);

            tiApplication.IsVisibleChanged += TiApplication_IsVisibleChanged;
            tiContractor.IsVisibleChanged += TiContractor_IsVisibleChanged;
            tiMark.IsVisibleChanged += TiMark_IsVisibleChanged;
            tiModel.IsVisibleChanged += TiModel_IsVisibleChanged;
            tiNomenclature.IsVisibleChanged += TiNomenclature_IsVisibleChanged;
            tiOption.IsVisibleChanged += TiOption_IsVisibleChanged;
            tiReason.IsVisibleChanged += TiReason_IsVisibleChanged;
            tiSetting.IsVisibleChanged += TiSetting_IsVisibleChanged;
            tiUnit.IsVisibleChanged += TiUnit_IsVisibleChanged;
            tiWorkingHour.IsVisibleChanged += TiWorkingHour_IsVisibleChanged;
            
        }

        private void ClosingTabPage(ref TabItem page)
        {

            if (tcJournals.SelectedItem == page)
                for (int i = tcJournals.Items.Count - 1; i >= 0; i--)
                {
                    var item = (TabItem)tcJournals.Items[i];
                    if (item.Visibility == Visibility.Visible && item != page)
                    {
                        tcJournals.SelectedItem = item;
                        break;
                    }
                }
            page.Visibility = Visibility.Collapsed;
        }
            

        private void TiWorkingHour_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiWorkingHour, ref wfhWorkingHour);
        }

        private void TiUnit_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiUnit, ref wfhUnit);
        }

        private void TiSetting_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiSetting, ref wfhSetting);
        }

        private void TiReason_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiReason, ref wfhReason);
        }

        private void TiOption_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiOption, ref wfhOption);
        }

        private void TiNomenclature_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiNomenclature, ref wfhNomenclature);
        }

        private void TiModel_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiModel, ref wfhModel);
        }

        private void TiMark_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiMark, ref wfhMark);
        }

        private void TiContractor_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiContractor, ref wfhContractor);
        }

        private void TiApplication_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WindowsHostVisibility(ref tiApplication, ref wfhApptication);
        }
        
        private void WindowsHostVisibility(ref TabItem item, ref WindowsFormsHost host)
        {
            if (item.IsVisible)
            {
                host.Visibility = Visibility.Visible;
            }
            else
            {
                host.Visibility = Visibility.Collapsed;
            }
        }

        private void CreateControls(ToolStripContainer container, ToolStrip toolStrip, DataGridView dataGrid, ToolStripButton add, ToolStripButton edit, ToolStripButton delete, ToolStripButton update, ToolStripLabel labelSeach, ToolStripTextBox textBoxSeach)
        {
            // 
            // container.ContentPanel
            // 
            container.ContentPanel.Controls.Add(dataGrid);
            container.ContentPanel.Size = new System.Drawing.Size(826, 184);
            container.Dock = DockStyle.Fill;
            container.Location = new System.Drawing.Point(0, 0);
            container.Size = new System.Drawing.Size(826, 221);
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            container.TopToolStripPanel.Controls.Add(toolStrip);
            //
            // toolStrip
            //
            toolStrip.AutoSize = false;
            toolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            toolStrip.CanOverflow = false;
            toolStrip.Dock = DockStyle.None;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new ToolStripItem[] {
            add,
            edit,
            delete,
            update,
            textBoxSeach,
            labelSeach});
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "TS_Application";
            toolStrip.Size = new System.Drawing.Size(820, 30);
            toolStrip.Stretch = true;
            // 
            // textBoxSeach
            // 
            textBoxSeach.Alignment = ToolStripItemAlignment.Right;
            textBoxSeach.Margin = new Padding(0, 5, 20, 5);
            textBoxSeach.Size = new System.Drawing.Size(250, 20);
            // 
            // labelSeach
            // 
            labelSeach.Alignment = ToolStripItemAlignment.Right;
            labelSeach.Margin = new Padding(0, 12, 10, 12);
            labelSeach.Size = new System.Drawing.Size(45, 20);
            labelSeach.Text = "Поиск:";
            // 
            // add
            // 
            add.BackColor = System.Drawing.Color.LightGray;
            add.Image = Icons.Add.ToBitmap();
            add.ImageTransparentColor = System.Drawing.Color.Magenta;
            add.Margin = new Padding(20, 12, 0, 12);
            add.Size = new System.Drawing.Size(79, 20);
            add.Text = "Добавить";
            // 
            // edit
            // 
            edit.BackColor = System.Drawing.Color.LightGray;
            edit.Image = Icons.Edit.ToBitmap();
            edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            edit.Margin = new Padding(10, 12, 0, 12);
            edit.Size = new System.Drawing.Size(81, 20);
            edit.Text = "Изменить";
            // 
            // delete
            // 
            delete.BackColor = System.Drawing.Color.LightGray;
            delete.Image = Icons.Basket.ToBitmap();
            delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            delete.Margin = new Padding(10, 12, 0, 12);
            delete.Size = new System.Drawing.Size(71, 20);
            delete.Text = "Удалить";
            // 
            // update
            // 
            update.BackColor = System.Drawing.Color.LightGray;
            update.Image = Icons.Update.ToBitmap();
            update.ImageTransparentColor = System.Drawing.Color.Magenta;
            update.Margin = new Padding(50, 12, 0, 12);
            update.Size = new System.Drawing.Size(81, 20);
            update.Text = "Обновить";

            dataGrid.Dock = DockStyle.Fill;
        }

        private void CreateAppticationControls()
        {
            TSC_Apptication = new ToolStripContainer();
            TS_Application = new ToolStrip();
            DGV_Apptications = new DataGridView();
            TSB_AddApplication = new ToolStripButton();
            TSB_EditApplication = new ToolStripButton();
            TSB_DeleteApplication = new ToolStripButton();
            TSB_UpdateApplication = new ToolStripButton();
            TSL_SeachApplication = new ToolStripLabel();
            TSTB_SeachApplication = new ToolStripTextBox();
            TSDDB_PrintApplication = new ToolStripDropDownButton();
            TSMI_PrintAcceptanceTransferOwnershipCertificate = new ToolStripMenuItem();
            TSMI_PrintCertificateCompletion = new ToolStripMenuItem();
            TSMI_PrintJopTicket = new ToolStripMenuItem();


            CreateControls(TSC_Apptication, TS_Application, DGV_Apptications, TSB_AddApplication, TSB_EditApplication, TSB_DeleteApplication, TSB_UpdateApplication, TSL_SeachApplication, TSTB_SeachApplication);
            
            this.TS_Application.Items.Add(TSDDB_PrintApplication);
            // 
            // TSDDB_Print
            // 
            this.TSDDB_PrintApplication.BackColor = System.Drawing.Color.LightGray;
            this.TSDDB_PrintApplication.DropDownItems.AddRange(new ToolStripItem[] {
            this.TSMI_PrintAcceptanceTransferOwnershipCertificate,
            this.TSMI_PrintJopTicket,
            this.TSMI_PrintCertificateCompletion });
            this.TSDDB_PrintApplication.Image = Icons.Print.ToBitmap();
            this.TSDDB_PrintApplication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDB_PrintApplication.Margin = new Padding(75, 12, 0, 12);
            this.TSDDB_PrintApplication.Name = "TSDDB_Print";
            this.TSDDB_PrintApplication.Size = new System.Drawing.Size(75, 20);
            this.TSDDB_PrintApplication.Text = "Печать";
            // 
            // приёмносдаточныйАктToolStripMenuItem
            // 
            this.TSMI_PrintAcceptanceTransferOwnershipCertificate.Name = "приёмносдаточныйАктToolStripMenuItem";
            this.TSMI_PrintAcceptanceTransferOwnershipCertificate.Size = new System.Drawing.Size(211, 22);
            this.TSMI_PrintAcceptanceTransferOwnershipCertificate.Text = "Приёмно-сдаточный акт";
            // 
            // нарядзаказToolStripMenuItem
            // 
            this.TSMI_PrintJopTicket.Name = "нарядзаказToolStripMenuItem";
            this.TSMI_PrintJopTicket.Size = new System.Drawing.Size(211, 22);
            this.TSMI_PrintJopTicket.Text = "Наряд-заказ";
            // 
            // актВыполненныхРаботToolStripMenuItem
            // 
            this.TSMI_PrintCertificateCompletion.Name = "актВыполненныхРаботToolStripMenuItem";
            this.TSMI_PrintCertificateCompletion.Size = new System.Drawing.Size(211, 22);
            this.TSMI_PrintCertificateCompletion.Text = "Акт выполненных работ";
            
            wfhApptication.Child = TSC_Apptication;
        }

        private void VisibilityTabPage(ref TabItem item)
        {
            if (item.Visibility == Visibility.Collapsed)
            {
                item.UpdateLayout();
                tcJournals.Items.Remove(item);
                tcJournals.Items.Add(item);
                tcJournals.SelectedItem = item;
                item.Visibility = Visibility.Visible;
            }
            else
                tcJournals.SelectedItem = item;
        }
    }
}
