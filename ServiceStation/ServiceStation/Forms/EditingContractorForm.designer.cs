namespace ServiceStation.Forms
{
    partial class EditingContractorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label L_View;
            System.Windows.Forms.Label L_INN;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingContractorForm));
            this.L_KPP = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CB_View = new System.Windows.Forms.ComboBox();
            this.TC_Informations = new System.Windows.Forms.TabControl();
            this.TP_Imprint = new System.Windows.Forms.TabPage();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.L_Address = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_OKPO = new System.Windows.Forms.TextBox();
            this.TB_KPP = new System.Windows.Forms.TextBox();
            this.TB_INN = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.L_OKPO = new System.Windows.Forms.Label();
            this.L_Phone = new System.Windows.Forms.Label();
            this.L_Email = new System.Windows.Forms.Label();
            this.TB_Cars = new System.Windows.Forms.TabPage();
            this.toolStripContainer4 = new System.Windows.Forms.ToolStripContainer();
            this.DGV_Cars = new System.Windows.Forms.DataGridView();
            this.TS_Vehicles = new System.Windows.Forms.ToolStrip();
            this.TSB_AddV = new System.Windows.Forms.ToolStripButton();
            this.TSB_EditV = new System.Windows.Forms.ToolStripButton();
            this.TSB_RemoveV = new System.Windows.Forms.ToolStripButton();
            this.TP_СontactPersones = new System.Windows.Forms.TabPage();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.DGV_ContactPersones = new System.Windows.Forms.DataGridView();
            this.TS_ContactPersones = new System.Windows.Forms.ToolStrip();
            this.TSB_AddCN = new System.Windows.Forms.ToolStripButton();
            this.TSB_EditCN = new System.Windows.Forms.ToolStripButton();
            this.TSB_RemoveCN = new System.Windows.Forms.ToolStripButton();
            this.TP_Additionally = new System.Windows.Forms.TabPage();
            this.RTB_Additionally = new System.Windows.Forms.RichTextBox();
            this.TB_FullName = new System.Windows.Forms.TextBox();
            this.TB_ShortName = new System.Windows.Forms.TextBox();
            this.L_FullName = new System.Windows.Forms.Label();
            this.TS_SavePanel = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            L_View = new System.Windows.Forms.Label();
            L_INN = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TC_Informations.SuspendLayout();
            this.TP_Imprint.SuspendLayout();
            this.TB_Cars.SuspendLayout();
            this.toolStripContainer4.ContentPanel.SuspendLayout();
            this.toolStripContainer4.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cars)).BeginInit();
            this.TS_Vehicles.SuspendLayout();
            this.TP_СontactPersones.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ContactPersones)).BeginInit();
            this.TS_ContactPersones.SuspendLayout();
            this.TP_Additionally.SuspendLayout();
            this.TS_SavePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_View
            // 
            L_View.AutoSize = true;
            L_View.Location = new System.Drawing.Point(15, 17);
            L_View.Name = "L_View";
            L_View.Size = new System.Drawing.Size(95, 13);
            L_View.TabIndex = 1;
            L_View.Text = "Вид контрагента:";
            L_View.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_INN
            // 
            L_INN.AutoSize = true;
            L_INN.Location = new System.Drawing.Point(15, 17);
            L_INN.Name = "L_INN";
            L_INN.Size = new System.Drawing.Size(34, 13);
            L_INN.TabIndex = 7;
            L_INN.Text = "ИНН:";
            L_INN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_KPP
            // 
            this.L_KPP.AutoSize = true;
            this.L_KPP.Location = new System.Drawing.Point(15, 47);
            this.L_KPP.Name = "L_KPP";
            this.L_KPP.Size = new System.Drawing.Size(33, 13);
            this.L_KPP.TabIndex = 9;
            this.L_KPP.Text = "КПП:";
            this.L_KPP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(15, 7);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(129, 13);
            this.L_Name.TabIndex = 3;
            this.L_Name.Text = "Краткое наименование:";
            this.L_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(884, 353);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(884, 391);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_SavePanel);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CB_View);
            this.splitContainer1.Panel1.Controls.Add(L_View);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TC_Informations);
            this.splitContainer1.Panel2.Controls.Add(this.TB_FullName);
            this.splitContainer1.Panel2.Controls.Add(this.L_Name);
            this.splitContainer1.Panel2.Controls.Add(this.TB_ShortName);
            this.splitContainer1.Panel2.Controls.Add(this.L_FullName);
            this.splitContainer1.Size = new System.Drawing.Size(884, 353);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // CB_View
            // 
            this.CB_View.DisplayMember = "Вид";
            this.CB_View.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_View.FormattingEnabled = true;
            this.CB_View.Items.AddRange(new object[] {
            "Юридическое лицо",
            "Физическое лицо"});
            this.CB_View.Location = new System.Drawing.Point(150, 15);
            this.CB_View.Name = "CB_View";
            this.CB_View.Size = new System.Drawing.Size(200, 21);
            this.CB_View.TabIndex = 2;
            this.CB_View.ValueMember = "Вид";
            this.CB_View.SelectedIndexChanged += new System.EventHandler(this.CB_View_SelectedIndexChanged);
            this.CB_View.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TC_Informations
            // 
            this.TC_Informations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_Informations.Controls.Add(this.TP_Imprint);
            this.TC_Informations.Controls.Add(this.TB_Cars);
            this.TC_Informations.Controls.Add(this.TP_СontactPersones);
            this.TC_Informations.Controls.Add(this.TP_Additionally);
            this.TC_Informations.Location = new System.Drawing.Point(15, 70);
            this.TC_Informations.Name = "TC_Informations";
            this.TC_Informations.SelectedIndex = 0;
            this.TC_Informations.Size = new System.Drawing.Size(855, 242);
            this.TC_Informations.TabIndex = 6;
            this.TC_Informations.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TP_Imprint
            // 
            this.TP_Imprint.Controls.Add(this.TB_Address);
            this.TP_Imprint.Controls.Add(this.L_Address);
            this.TP_Imprint.Controls.Add(this.TB_Email);
            this.TP_Imprint.Controls.Add(this.TB_OKPO);
            this.TP_Imprint.Controls.Add(this.TB_KPP);
            this.TP_Imprint.Controls.Add(this.TB_INN);
            this.TP_Imprint.Controls.Add(this.TB_Phone);
            this.TP_Imprint.Controls.Add(this.L_OKPO);
            this.TP_Imprint.Controls.Add(this.L_KPP);
            this.TP_Imprint.Controls.Add(this.L_Phone);
            this.TP_Imprint.Controls.Add(L_INN);
            this.TP_Imprint.Controls.Add(this.L_Email);
            this.TP_Imprint.Location = new System.Drawing.Point(4, 22);
            this.TP_Imprint.Name = "TP_Imprint";
            this.TP_Imprint.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Imprint.Size = new System.Drawing.Size(847, 216);
            this.TP_Imprint.TabIndex = 0;
            this.TP_Imprint.Text = "Реквизиты";
            this.TP_Imprint.UseVisualStyleBackColor = true;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(120, 165);
            this.TB_Address.MaxLength = 100;
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(200, 20);
            this.TB_Address.TabIndex = 18;
            this.TB_Address.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_Address
            // 
            this.L_Address.AutoSize = true;
            this.L_Address.Location = new System.Drawing.Point(15, 167);
            this.L_Address.Name = "L_Address";
            this.L_Address.Size = new System.Drawing.Size(41, 13);
            this.L_Address.TabIndex = 17;
            this.L_Address.Text = "Адрес:";
            this.L_Address.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(120, 135);
            this.TB_Email.MaxLength = 40;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(200, 20);
            this.TB_Email.TabIndex = 16;
            this.TB_Email.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_OKPO
            // 
            this.TB_OKPO.Location = new System.Drawing.Point(120, 75);
            this.TB_OKPO.MaxLength = 10;
            this.TB_OKPO.Name = "TB_OKPO";
            this.TB_OKPO.Size = new System.Drawing.Size(200, 20);
            this.TB_OKPO.TabIndex = 12;
            this.TB_OKPO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_KPP
            // 
            this.TB_KPP.Location = new System.Drawing.Point(120, 45);
            this.TB_KPP.MaxLength = 10;
            this.TB_KPP.Name = "TB_KPP";
            this.TB_KPP.Size = new System.Drawing.Size(200, 20);
            this.TB_KPP.TabIndex = 10;
            this.TB_KPP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_INN
            // 
            this.TB_INN.Location = new System.Drawing.Point(120, 15);
            this.TB_INN.MaxLength = 12;
            this.TB_INN.Name = "TB_INN";
            this.TB_INN.Size = new System.Drawing.Size(200, 20);
            this.TB_INN.TabIndex = 8;
            this.TB_INN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(120, 105);
            this.TB_Phone.MaxLength = 11;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(200, 20);
            this.TB_Phone.TabIndex = 14;
            this.TB_Phone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_OKPO
            // 
            this.L_OKPO.AutoSize = true;
            this.L_OKPO.Location = new System.Drawing.Point(15, 77);
            this.L_OKPO.Name = "L_OKPO";
            this.L_OKPO.Size = new System.Drawing.Size(41, 13);
            this.L_OKPO.TabIndex = 11;
            this.L_OKPO.Text = "ОКПО:";
            this.L_OKPO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Location = new System.Drawing.Point(15, 107);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(55, 13);
            this.L_Phone.TabIndex = 13;
            this.L_Phone.Text = "Телефон:";
            this.L_Phone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_Email
            // 
            this.L_Email.AutoSize = true;
            this.L_Email.Location = new System.Drawing.Point(15, 137);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(38, 13);
            this.L_Email.TabIndex = 15;
            this.L_Email.Text = "E-mail:";
            this.L_Email.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_Cars
            // 
            this.TB_Cars.Controls.Add(this.toolStripContainer4);
            this.TB_Cars.Location = new System.Drawing.Point(4, 22);
            this.TB_Cars.Name = "TB_Cars";
            this.TB_Cars.Size = new System.Drawing.Size(847, 216);
            this.TB_Cars.TabIndex = 5;
            this.TB_Cars.Text = "Автомобили";
            this.TB_Cars.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer4
            // 
            this.toolStripContainer4.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer4.ContentPanel
            // 
            this.toolStripContainer4.ContentPanel.Controls.Add(this.DGV_Cars);
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(847, 178);
            this.toolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer4.LeftToolStripPanelVisible = false;
            this.toolStripContainer4.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.RightToolStripPanelVisible = false;
            this.toolStripContainer4.Size = new System.Drawing.Size(847, 216);
            this.toolStripContainer4.TabIndex = 0;
            this.toolStripContainer4.Text = "toolStripContainer4";
            // 
            // toolStripContainer4.TopToolStripPanel
            // 
            this.toolStripContainer4.TopToolStripPanel.Controls.Add(this.TS_Vehicles);
            // 
            // DGV_Cars
            // 
            this.DGV_Cars.AllowUserToAddRows = false;
            this.DGV_Cars.AllowUserToDeleteRows = false;
            this.DGV_Cars.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Cars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Cars.Location = new System.Drawing.Point(0, 0);
            this.DGV_Cars.Name = "DGV_Cars";
            this.DGV_Cars.ReadOnly = true;
            this.DGV_Cars.Size = new System.Drawing.Size(847, 178);
            this.DGV_Cars.TabIndex = 20;
            this.DGV_Cars.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TS_Vehicles
            // 
            this.TS_Vehicles.AutoSize = false;
            this.TS_Vehicles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Vehicles.CanOverflow = false;
            this.TS_Vehicles.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Vehicles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Vehicles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_AddV,
            this.TSB_EditV,
            this.TSB_RemoveV});
            this.TS_Vehicles.Location = new System.Drawing.Point(0, 0);
            this.TS_Vehicles.Name = "TS_Vehicles";
            this.TS_Vehicles.Size = new System.Drawing.Size(847, 38);
            this.TS_Vehicles.Stretch = true;
            this.TS_Vehicles.TabIndex = 19;
            this.TS_Vehicles.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TSB_AddV
            // 
            this.TSB_AddV.BackColor = System.Drawing.Color.LightGray;
            this.TSB_AddV.Image = ((System.Drawing.Image)(resources.GetObject("TSB_AddV.Image")));
            this.TSB_AddV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_AddV.Margin = new System.Windows.Forms.Padding(20, 9, 0, 9);
            this.TSB_AddV.Name = "TSB_AddV";
            this.TSB_AddV.Size = new System.Drawing.Size(79, 20);
            this.TSB_AddV.Text = "Добавить";
            // 
            // TSB_EditV
            // 
            this.TSB_EditV.BackColor = System.Drawing.Color.LightGray;
            this.TSB_EditV.Image = global::ServiceStation.Properties.Resources.Edit;
            this.TSB_EditV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_EditV.Margin = new System.Windows.Forms.Padding(10, 9, 0, 9);
            this.TSB_EditV.Name = "TSB_EditV";
            this.TSB_EditV.Size = new System.Drawing.Size(81, 20);
            this.TSB_EditV.Text = "Изменить";
            // 
            // TSB_RemoveV
            // 
            this.TSB_RemoveV.BackColor = System.Drawing.Color.LightGray;
            this.TSB_RemoveV.Image = ((System.Drawing.Image)(resources.GetObject("TSB_RemoveV.Image")));
            this.TSB_RemoveV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_RemoveV.Margin = new System.Windows.Forms.Padding(10, 9, 0, 9);
            this.TSB_RemoveV.Name = "TSB_RemoveV";
            this.TSB_RemoveV.Size = new System.Drawing.Size(71, 20);
            this.TSB_RemoveV.Text = "Удалить";
            // 
            // TP_СontactPersones
            // 
            this.TP_СontactPersones.Controls.Add(this.toolStripContainer3);
            this.TP_СontactPersones.Location = new System.Drawing.Point(4, 22);
            this.TP_СontactPersones.Name = "TP_СontactPersones";
            this.TP_СontactPersones.Padding = new System.Windows.Forms.Padding(3);
            this.TP_СontactPersones.Size = new System.Drawing.Size(847, 216);
            this.TP_СontactPersones.TabIndex = 4;
            this.TP_СontactPersones.Text = "Контактные лица";
            this.TP_СontactPersones.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer3
            // 
            this.toolStripContainer3.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.Controls.Add(this.DGV_ContactPersones);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(841, 170);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.LeftToolStripPanelVisible = false;
            this.toolStripContainer3.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.RightToolStripPanelVisible = false;
            this.toolStripContainer3.Size = new System.Drawing.Size(841, 210);
            this.toolStripContainer3.TabIndex = 0;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.TS_ContactPersones);
            // 
            // DGV_ContactPersones
            // 
            this.DGV_ContactPersones.AllowUserToAddRows = false;
            this.DGV_ContactPersones.AllowUserToDeleteRows = false;
            this.DGV_ContactPersones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ContactPersones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_ContactPersones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ContactPersones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_ContactPersones.Location = new System.Drawing.Point(0, 0);
            this.DGV_ContactPersones.Name = "DGV_ContactPersones";
            this.DGV_ContactPersones.ReadOnly = true;
            this.DGV_ContactPersones.Size = new System.Drawing.Size(841, 170);
            this.DGV_ContactPersones.TabIndex = 22;
            this.DGV_ContactPersones.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TS_ContactPersones
            // 
            this.TS_ContactPersones.AutoSize = false;
            this.TS_ContactPersones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_ContactPersones.CanOverflow = false;
            this.TS_ContactPersones.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_ContactPersones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_ContactPersones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_AddCN,
            this.TSB_EditCN,
            this.TSB_RemoveCN});
            this.TS_ContactPersones.Location = new System.Drawing.Point(0, 0);
            this.TS_ContactPersones.Name = "TS_ContactPersones";
            this.TS_ContactPersones.Size = new System.Drawing.Size(841, 40);
            this.TS_ContactPersones.Stretch = true;
            this.TS_ContactPersones.TabIndex = 21;
            this.TS_ContactPersones.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TSB_AddCN
            // 
            this.TSB_AddCN.BackColor = System.Drawing.Color.LightGray;
            this.TSB_AddCN.Image = ((System.Drawing.Image)(resources.GetObject("TSB_AddCN.Image")));
            this.TSB_AddCN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_AddCN.Margin = new System.Windows.Forms.Padding(20, 9, 0, 9);
            this.TSB_AddCN.Name = "TSB_AddCN";
            this.TSB_AddCN.Size = new System.Drawing.Size(79, 22);
            this.TSB_AddCN.Text = "Добавить";
            // 
            // TSB_EditCN
            // 
            this.TSB_EditCN.BackColor = System.Drawing.Color.LightGray;
            this.TSB_EditCN.Image = ((System.Drawing.Image)(resources.GetObject("TSB_EditCN.Image")));
            this.TSB_EditCN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_EditCN.Margin = new System.Windows.Forms.Padding(10, 9, 0, 9);
            this.TSB_EditCN.Name = "TSB_EditCN";
            this.TSB_EditCN.Size = new System.Drawing.Size(81, 22);
            this.TSB_EditCN.Text = "Изменить";
            // 
            // TSB_RemoveCN
            // 
            this.TSB_RemoveCN.BackColor = System.Drawing.Color.LightGray;
            this.TSB_RemoveCN.Image = ((System.Drawing.Image)(resources.GetObject("TSB_RemoveCN.Image")));
            this.TSB_RemoveCN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_RemoveCN.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.TSB_RemoveCN.Name = "TSB_RemoveCN";
            this.TSB_RemoveCN.Size = new System.Drawing.Size(71, 20);
            this.TSB_RemoveCN.Text = "Удалить";
            // 
            // TP_Additionally
            // 
            this.TP_Additionally.Controls.Add(this.RTB_Additionally);
            this.TP_Additionally.Location = new System.Drawing.Point(4, 22);
            this.TP_Additionally.Name = "TP_Additionally";
            this.TP_Additionally.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Additionally.Size = new System.Drawing.Size(847, 216);
            this.TP_Additionally.TabIndex = 2;
            this.TP_Additionally.Text = "Дополнительно";
            this.TP_Additionally.UseVisualStyleBackColor = true;
            // 
            // RTB_Additionally
            // 
            this.RTB_Additionally.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Additionally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Additionally.Location = new System.Drawing.Point(3, 3);
            this.RTB_Additionally.MaxLength = 4000;
            this.RTB_Additionally.Name = "RTB_Additionally";
            this.RTB_Additionally.Size = new System.Drawing.Size(841, 210);
            this.RTB_Additionally.TabIndex = 23;
            this.RTB_Additionally.Text = "";
            this.RTB_Additionally.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_FullName
            // 
            this.TB_FullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_FullName.Location = new System.Drawing.Point(150, 35);
            this.TB_FullName.MaxLength = 300;
            this.TB_FullName.Name = "TB_FullName";
            this.TB_FullName.Size = new System.Drawing.Size(715, 20);
            this.TB_FullName.TabIndex = 5;
            this.TB_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TB_ShortName
            // 
            this.TB_ShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ShortName.Location = new System.Drawing.Point(150, 5);
            this.TB_ShortName.MaxLength = 150;
            this.TB_ShortName.Name = "TB_ShortName";
            this.TB_ShortName.Size = new System.Drawing.Size(715, 20);
            this.TB_ShortName.TabIndex = 4;
            this.TB_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // L_FullName
            // 
            this.L_FullName.AutoSize = true;
            this.L_FullName.Location = new System.Drawing.Point(15, 37);
            this.L_FullName.Name = "L_FullName";
            this.L_FullName.Size = new System.Drawing.Size(125, 13);
            this.L_FullName.TabIndex = 4;
            this.L_FullName.Text = "Полное наименование:";
            this.L_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TS_SavePanel
            // 
            this.TS_SavePanel.AutoSize = false;
            this.TS_SavePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_SavePanel.CanOverflow = false;
            this.TS_SavePanel.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_SavePanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_SavePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Censel});
            this.TS_SavePanel.Location = new System.Drawing.Point(0, 0);
            this.TS_SavePanel.Name = "TS_SavePanel";
            this.TS_SavePanel.Size = new System.Drawing.Size(884, 38);
            this.TS_SavePanel.Stretch = true;
            this.TS_SavePanel.TabIndex = 0;
            this.TS_SavePanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            // 
            // TSB_Save
            // 
            this.TSB_Save.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Save.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Save.Image")));
            this.TSB_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Save.Margin = new System.Windows.Forms.Padding(20, 9, 0, 9);
            this.TSB_Save.Name = "TSB_Save";
            this.TSB_Save.Size = new System.Drawing.Size(85, 20);
            this.TSB_Save.Text = "Сохранить";
            // 
            // TSB_Censel
            // 
            this.TSB_Censel.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Censel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Censel.Image")));
            this.TSB_Censel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Censel.Margin = new System.Windows.Forms.Padding(10, 9, 0, 9);
            this.TSB_Censel.Name = "TSB_Censel";
            this.TSB_Censel.Size = new System.Drawing.Size(69, 20);
            this.TSB_Censel.Text = "Отмена";
            // 
            // EditingContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 391);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditingContractorForm";
            this.ShowInTaskbar = false;
            this.Text = "Контрагенты";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContractorForm_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TC_Informations.ResumeLayout(false);
            this.TP_Imprint.ResumeLayout(false);
            this.TP_Imprint.PerformLayout();
            this.TB_Cars.ResumeLayout(false);
            this.toolStripContainer4.ContentPanel.ResumeLayout(false);
            this.toolStripContainer4.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer4.ResumeLayout(false);
            this.toolStripContainer4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cars)).EndInit();
            this.TS_Vehicles.ResumeLayout(false);
            this.TS_Vehicles.PerformLayout();
            this.TP_СontactPersones.ResumeLayout(false);
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ContactPersones)).EndInit();
            this.TS_ContactPersones.ResumeLayout(false);
            this.TS_ContactPersones.PerformLayout();
            this.TP_Additionally.ResumeLayout(false);
            this.TS_SavePanel.ResumeLayout(false);
            this.TS_SavePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_SavePanel;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CB_View;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.TextBox TB_FullName;
        private System.Windows.Forms.TextBox TB_ShortName;
        private System.Windows.Forms.Label L_FullName;
        private System.Windows.Forms.TabControl TC_Informations;
        private System.Windows.Forms.TabPage TP_Imprint;
        private System.Windows.Forms.TextBox TB_OKPO;
        private System.Windows.Forms.TextBox TB_KPP;
        private System.Windows.Forms.TextBox TB_INN;
        private System.Windows.Forms.Label L_OKPO;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TabPage TP_Additionally;
        private System.Windows.Forms.RichTextBox RTB_Additionally;
        private System.Windows.Forms.TabPage TP_СontactPersones;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.DataGridView DGV_ContactPersones;
        private System.Windows.Forms.ToolStrip TS_ContactPersones;
        private System.Windows.Forms.ToolStripButton TSB_AddCN;
        private System.Windows.Forms.ToolStripButton TSB_EditCN;
        private System.Windows.Forms.Label L_KPP;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.TabPage TB_Cars;
        private System.Windows.Forms.ToolStripContainer toolStripContainer4;
        private System.Windows.Forms.DataGridView DGV_Cars;
        private System.Windows.Forms.ToolStripButton TSB_RemoveCN;
        private System.Windows.Forms.ToolStrip TS_Vehicles;
        private System.Windows.Forms.ToolStripButton TSB_AddV;
        private System.Windows.Forms.ToolStripButton TSB_EditV;
        private System.Windows.Forms.ToolStripButton TSB_RemoveV;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.Label L_Address;
        private System.Windows.Forms.TextBox TB_Address;
    }
}