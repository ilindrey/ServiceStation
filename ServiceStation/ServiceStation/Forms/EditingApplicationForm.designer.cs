namespace ServiceStation.Forms
{
    partial class EditingApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingApplicationForm));
            this.L_Date = new System.Windows.Forms.Label();
            this.L_Representative = new System.Windows.Forms.Label();
            this.L_Number = new System.Windows.Forms.Label();
            this.L_Counterparty = new System.Windows.Forms.Label();
            this.DTP_FirstControlTime = new System.Windows.Forms.DateTimePicker();
            this.DTP_SecondControlTime = new System.Windows.Forms.DateTimePicker();
            this.L_FirstControlTime = new System.Windows.Forms.Label();
            this.L_SecondControlTime = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TS_Total = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TSL_Sum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.SC_DataApplication = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_Extradition = new System.Windows.Forms.DateTimePicker();
            this.DTP_Readiness = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LL_Responsible = new System.Windows.Forms.LinkLabel();
            this.LL_Car = new System.Windows.Forms.LinkLabel();
            this.LL_Contractor = new System.Windows.Forms.LinkLabel();
            this.LL_ContactPerson = new System.Windows.Forms.LinkLabel();
            this.TB_Number = new ViewOnlyTextBox.ViewOnlyTextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.L_Type = new System.Windows.Forms.Label();
            this.L_Responsible = new System.Windows.Forms.Label();
            this.B_ClearCN = new System.Windows.Forms.Button();
            this.LL_PowerOfAttorney = new System.Windows.Forms.LinkLabel();
            this.L_Car = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.DGV_Options = new System.Windows.Forms.DataGridView();
            this.TS_Options = new System.Windows.Forms.ToolStrip();
            this.TSB_AddOption = new System.Windows.Forms.ToolStripButton();
            this.TSB_DeleteOption = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.DGV_Reasons = new System.Windows.Forms.DataGridView();
            this.TS_Reasons = new System.Windows.Forms.ToolStrip();
            this.TSB_AddReason = new System.Windows.Forms.ToolStripButton();
            this.TSB_EditReason = new System.Windows.Forms.ToolStripButton();
            this.TSB_DeleteReason = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RTB_Revealed = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RTB_Other = new System.Windows.Forms.RichTextBox();
            this.TS_SavePanel = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.TS_Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_DataApplication)).BeginInit();
            this.SC_DataApplication.Panel1.SuspendLayout();
            this.SC_DataApplication.Panel2.SuspendLayout();
            this.SC_DataApplication.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Options)).BeginInit();
            this.TS_Options.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reasons)).BeginInit();
            this.TS_Reasons.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.TS_SavePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Date
            // 
            this.L_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Date.AutoSize = true;
            this.L_Date.Location = new System.Drawing.Point(455, 50);
            this.L_Date.Name = "L_Date";
            this.L_Date.Size = new System.Drawing.Size(36, 13);
            this.L_Date.TabIndex = 9;
            this.L_Date.Text = "Дата:";
            this.L_Date.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_Representative
            // 
            this.L_Representative.AutoSize = true;
            this.L_Representative.Location = new System.Drawing.Point(15, 50);
            this.L_Representative.Name = "L_Representative";
            this.L_Representative.Size = new System.Drawing.Size(96, 13);
            this.L_Representative.TabIndex = 5;
            this.L_Representative.Text = "Контактное лицо:";
            this.L_Representative.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_Number
            // 
            this.L_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Number.AutoSize = true;
            this.L_Number.Location = new System.Drawing.Point(455, 20);
            this.L_Number.Name = "L_Number";
            this.L_Number.Size = new System.Drawing.Size(44, 13);
            this.L_Number.TabIndex = 3;
            this.L_Number.Text = "Номер:";
            this.L_Number.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_Counterparty
            // 
            this.L_Counterparty.AutoSize = true;
            this.L_Counterparty.Location = new System.Drawing.Point(15, 20);
            this.L_Counterparty.Name = "L_Counterparty";
            this.L_Counterparty.Size = new System.Drawing.Size(68, 13);
            this.L_Counterparty.TabIndex = 1;
            this.L_Counterparty.Text = "Контрагент:";
            this.L_Counterparty.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // DTP_FirstControlTime
            // 
            this.DTP_FirstControlTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_FirstControlTime.CustomFormat = " ";
            this.DTP_FirstControlTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_FirstControlTime.Location = new System.Drawing.Point(615, 78);
            this.DTP_FirstControlTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DTP_FirstControlTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTP_FirstControlTime.Name = "DTP_FirstControlTime";
            this.DTP_FirstControlTime.Size = new System.Drawing.Size(200, 20);
            this.DTP_FirstControlTime.TabIndex = 14;
            this.DTP_FirstControlTime.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DTP_FirstControlTime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // DTP_SecondControlTime
            // 
            this.DTP_SecondControlTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_SecondControlTime.CustomFormat = "  ";
            this.DTP_SecondControlTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_SecondControlTime.Location = new System.Drawing.Point(615, 108);
            this.DTP_SecondControlTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DTP_SecondControlTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTP_SecondControlTime.Name = "DTP_SecondControlTime";
            this.DTP_SecondControlTime.Size = new System.Drawing.Size(200, 20);
            this.DTP_SecondControlTime.TabIndex = 16;
            this.DTP_SecondControlTime.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DTP_SecondControlTime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_FirstControlTime
            // 
            this.L_FirstControlTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_FirstControlTime.AutoSize = true;
            this.L_FirstControlTime.Location = new System.Drawing.Point(455, 80);
            this.L_FirstControlTime.Name = "L_FirstControlTime";
            this.L_FirstControlTime.Size = new System.Drawing.Size(151, 13);
            this.L_FirstControlTime.TabIndex = 13;
            this.L_FirstControlTime.Text = "Первое контрольное время:";
            this.L_FirstControlTime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_SecondControlTime
            // 
            this.L_SecondControlTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_SecondControlTime.AutoSize = true;
            this.L_SecondControlTime.Location = new System.Drawing.Point(455, 110);
            this.L_SecondControlTime.Name = "L_SecondControlTime";
            this.L_SecondControlTime.Size = new System.Drawing.Size(149, 13);
            this.L_SecondControlTime.TabIndex = 15;
            this.L_SecondControlTime.Text = "Второе контрольное время:";
            this.L_SecondControlTime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.TS_Total);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.SC_DataApplication);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(834, 450);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(834, 511);
            this.toolStripContainer1.TabIndex = 19;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_SavePanel);
            // 
            // TS_Total
            // 
            this.TS_Total.AutoSize = false;
            this.TS_Total.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Total.CanOverflow = false;
            this.TS_Total.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Total.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Total.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TSL_Sum,
            this.toolStripLabel3});
            this.TS_Total.Location = new System.Drawing.Point(0, 0);
            this.TS_Total.Name = "TS_Total";
            this.TS_Total.Size = new System.Drawing.Size(834, 25);
            this.TS_Total.Stretch = true;
            this.TS_Total.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "Цена услуги:";
            // 
            // TSL_Sum
            // 
            this.TSL_Sum.Name = "TSL_Sum";
            this.TSL_Sum.Size = new System.Drawing.Size(28, 22);
            this.TSL_Sum.Text = "0,00";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel3.Text = "рублей";
            // 
            // SC_DataApplication
            // 
            this.SC_DataApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_DataApplication.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SC_DataApplication.IsSplitterFixed = true;
            this.SC_DataApplication.Location = new System.Drawing.Point(0, 0);
            this.SC_DataApplication.Name = "SC_DataApplication";
            this.SC_DataApplication.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SC_DataApplication.Panel1
            // 
            this.SC_DataApplication.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SC_DataApplication.Panel1.Controls.Add(this.label2);
            this.SC_DataApplication.Panel1.Controls.Add(this.DTP_Extradition);
            this.SC_DataApplication.Panel1.Controls.Add(this.DTP_Readiness);
            this.SC_DataApplication.Panel1.Controls.Add(this.label1);
            this.SC_DataApplication.Panel1.Controls.Add(this.LL_Responsible);
            this.SC_DataApplication.Panel1.Controls.Add(this.LL_Car);
            this.SC_DataApplication.Panel1.Controls.Add(this.LL_Contractor);
            this.SC_DataApplication.Panel1.Controls.Add(this.LL_ContactPerson);
            this.SC_DataApplication.Panel1.Controls.Add(this.TB_Number);
            this.SC_DataApplication.Panel1.Controls.Add(this.DTP_Date);
            this.SC_DataApplication.Panel1.Controls.Add(this.CB_Type);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_Type);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_Responsible);
            this.SC_DataApplication.Panel1.Controls.Add(this.B_ClearCN);
            this.SC_DataApplication.Panel1.Controls.Add(this.LL_PowerOfAttorney);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_Car);
            this.SC_DataApplication.Panel1.Controls.Add(this.DTP_SecondControlTime);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_Counterparty);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_Number);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_SecondControlTime);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_FirstControlTime);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_Representative);
            this.SC_DataApplication.Panel1.Controls.Add(this.L_Date);
            this.SC_DataApplication.Panel1.Controls.Add(this.DTP_FirstControlTime);
            this.SC_DataApplication.Panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // SC_DataApplication.Panel2
            // 
            this.SC_DataApplication.Panel2.Controls.Add(this.tabControl);
            this.SC_DataApplication.Size = new System.Drawing.Size(834, 450);
            this.SC_DataApplication.SplitterDistance = 200;
            this.SC_DataApplication.SplitterWidth = 1;
            this.SC_DataApplication.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дата выдачи заказа:";
            this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // DTP_Extradition
            // 
            this.DTP_Extradition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Extradition.CustomFormat = " ";
            this.DTP_Extradition.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Extradition.Location = new System.Drawing.Point(615, 168);
            this.DTP_Extradition.Name = "DTP_Extradition";
            this.DTP_Extradition.Size = new System.Drawing.Size(200, 20);
            this.DTP_Extradition.TabIndex = 24;
            this.DTP_Extradition.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DTP_Extradition.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // DTP_Readiness
            // 
            this.DTP_Readiness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Readiness.CustomFormat = " ";
            this.DTP_Readiness.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Readiness.Location = new System.Drawing.Point(615, 138);
            this.DTP_Readiness.Name = "DTP_Readiness";
            this.DTP_Readiness.Size = new System.Drawing.Size(200, 20);
            this.DTP_Readiness.TabIndex = 22;
            this.DTP_Readiness.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.DTP_Readiness.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Дата готовности:";
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // LL_Responsible
            // 
            this.LL_Responsible.AutoSize = true;
            this.LL_Responsible.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Responsible.Location = new System.Drawing.Point(180, 120);
            this.LL_Responsible.Name = "LL_Responsible";
            this.LL_Responsible.Size = new System.Drawing.Size(50, 13);
            this.LL_Responsible.TabIndex = 18;
            this.LL_Responsible.TabStop = true;
            this.LL_Responsible.Text = "выбрать";
            this.LL_Responsible.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Responsible_LinkClicked);
            this.LL_Responsible.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // LL_Car
            // 
            this.LL_Car.AutoSize = true;
            this.LL_Car.Enabled = false;
            this.LL_Car.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Car.Location = new System.Drawing.Point(180, 90);
            this.LL_Car.Name = "LL_Car";
            this.LL_Car.Size = new System.Drawing.Size(50, 13);
            this.LL_Car.TabIndex = 12;
            this.LL_Car.TabStop = true;
            this.LL_Car.Text = "выбрать";
            this.LL_Car.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Car_LinkClicked);
            this.LL_Car.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // LL_Contractor
            // 
            this.LL_Contractor.AutoSize = true;
            this.LL_Contractor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Contractor.Location = new System.Drawing.Point(180, 20);
            this.LL_Contractor.Name = "LL_Contractor";
            this.LL_Contractor.Size = new System.Drawing.Size(50, 13);
            this.LL_Contractor.TabIndex = 2;
            this.LL_Contractor.TabStop = true;
            this.LL_Contractor.Text = "выбрать";
            this.LL_Contractor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Contractor_LinkClicked);
            this.LL_Contractor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // LL_ContactPerson
            // 
            this.LL_ContactPerson.AutoSize = true;
            this.LL_ContactPerson.Enabled = false;
            this.LL_ContactPerson.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_ContactPerson.Location = new System.Drawing.Point(180, 50);
            this.LL_ContactPerson.Name = "LL_ContactPerson";
            this.LL_ContactPerson.Size = new System.Drawing.Size(50, 13);
            this.LL_ContactPerson.TabIndex = 7;
            this.LL_ContactPerson.TabStop = true;
            this.LL_ContactPerson.Text = "выбрать";
            this.LL_ContactPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ContactPerson_LinkClicked);
            this.LL_ContactPerson.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // TB_Number
            // 
            this.TB_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Number.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TB_Number.Location = new System.Drawing.Point(615, 18);
            this.TB_Number.Name = "TB_Number";
            this.TB_Number.Size = new System.Drawing.Size(200, 20);
            this.TB_Number.TabIndex = 4;
            this.TB_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Number.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Date.Location = new System.Drawing.Point(615, 48);
            this.DTP_Date.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(200, 20);
            this.DTP_Date.TabIndex = 10;
            this.DTP_Date.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // CB_Type
            // 
            this.CB_Type.AutoCompleteCustomSource.AddRange(new string[] {
            "Текущий",
            "Гарантийный"});
            this.CB_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "Текущий",
            "Гарантийный"});
            this.CB_Type.Location = new System.Drawing.Point(180, 150);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(200, 21);
            this.CB_Type.TabIndex = 20;
            this.CB_Type.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_Type
            // 
            this.L_Type.AutoSize = true;
            this.L_Type.Location = new System.Drawing.Point(15, 150);
            this.L_Type.Name = "L_Type";
            this.L_Type.Size = new System.Drawing.Size(75, 13);
            this.L_Type.TabIndex = 19;
            this.L_Type.Text = "Тип ремонта:";
            this.L_Type.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_Responsible
            // 
            this.L_Responsible.AutoSize = true;
            this.L_Responsible.Location = new System.Drawing.Point(15, 120);
            this.L_Responsible.Name = "L_Responsible";
            this.L_Responsible.Size = new System.Drawing.Size(89, 13);
            this.L_Responsible.TabIndex = 17;
            this.L_Responsible.Text = "Ответственный:";
            this.L_Responsible.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // B_ClearCN
            // 
            this.B_ClearCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.B_ClearCN.Image = ((System.Drawing.Image)(resources.GetObject("B_ClearCN.Image")));
            this.B_ClearCN.Location = new System.Drawing.Point(151, 50);
            this.B_ClearCN.Name = "B_ClearCN";
            this.B_ClearCN.Size = new System.Drawing.Size(23, 23);
            this.B_ClearCN.TabIndex = 6;
            this.B_ClearCN.UseVisualStyleBackColor = false;
            this.B_ClearCN.Click += new System.EventHandler(this.B_ClearContactPerson_Click);
            this.B_ClearCN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // LL_PowerOfAttorney
            // 
            this.LL_PowerOfAttorney.AutoSize = true;
            this.LL_PowerOfAttorney.Enabled = false;
            this.LL_PowerOfAttorney.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_PowerOfAttorney.Location = new System.Drawing.Point(180, 65);
            this.LL_PowerOfAttorney.Name = "LL_PowerOfAttorney";
            this.LL_PowerOfAttorney.Size = new System.Drawing.Size(78, 13);
            this.LL_PowerOfAttorney.TabIndex = 8;
            this.LL_PowerOfAttorney.TabStop = true;
            this.LL_PowerOfAttorney.Text = "доверенность";
            this.LL_PowerOfAttorney.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_PowerOfAttorney_LinkClicked);
            this.LL_PowerOfAttorney.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // L_Car
            // 
            this.L_Car.AutoSize = true;
            this.L_Car.Location = new System.Drawing.Point(15, 90);
            this.L_Car.Name = "L_Car";
            this.L_Car.Size = new System.Drawing.Size(72, 13);
            this.L_Car.TabIndex = 11;
            this.L_Car.Text = "Автомобиль:";
            this.L_Car.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(834, 249);
            this.tabControl.TabIndex = 30;
            this.tabControl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStripContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(826, 223);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Комплектации";
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.Controls.Add(this.DGV_Options);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(826, 187);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(826, 223);
            this.toolStripContainer3.TabIndex = 1;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.TS_Options);
            // 
            // DGV_Options
            // 
            this.DGV_Options.AllowUserToAddRows = false;
            this.DGV_Options.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Options.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Options.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Options.Location = new System.Drawing.Point(0, 0);
            this.DGV_Options.MultiSelect = false;
            this.DGV_Options.Name = "DGV_Options";
            this.DGV_Options.RowTemplate.ReadOnly = true;
            this.DGV_Options.Size = new System.Drawing.Size(826, 187);
            this.DGV_Options.TabIndex = 26;
            this.DGV_Options.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // TS_Options
            // 
            this.TS_Options.AutoSize = false;
            this.TS_Options.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Options.CanOverflow = false;
            this.TS_Options.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Options.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_AddOption,
            this.TSB_DeleteOption});
            this.TS_Options.Location = new System.Drawing.Point(0, 0);
            this.TS_Options.Name = "TS_Options";
            this.TS_Options.Size = new System.Drawing.Size(826, 36);
            this.TS_Options.Stretch = true;
            this.TS_Options.TabIndex = 25;
            this.TS_Options.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // TSB_AddOption
            // 
            this.TSB_AddOption.BackColor = System.Drawing.Color.LightGray;
            this.TSB_AddOption.Image = global::ServiceStation.Properties.Resources.Add;
            this.TSB_AddOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_AddOption.Margin = new System.Windows.Forms.Padding(20, 9, 0, 7);
            this.TSB_AddOption.Name = "TSB_AddOption";
            this.TSB_AddOption.Size = new System.Drawing.Size(79, 20);
            this.TSB_AddOption.Text = "Добавить";
            this.TSB_AddOption.Click += new System.EventHandler(this.TSB_AddOption_Click);
            // 
            // TSB_DeleteOption
            // 
            this.TSB_DeleteOption.BackColor = System.Drawing.Color.LightGray;
            this.TSB_DeleteOption.Image = global::ServiceStation.Properties.Resources.Basket;
            this.TSB_DeleteOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_DeleteOption.Margin = new System.Windows.Forms.Padding(10, 9, 0, 7);
            this.TSB_DeleteOption.Name = "TSB_DeleteOption";
            this.TSB_DeleteOption.Size = new System.Drawing.Size(71, 20);
            this.TSB_DeleteOption.Text = "Удалить";
            this.TSB_DeleteOption.Click += new System.EventHandler(this.TSB_DeleteOption_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStripContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Причины обращения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.DGV_Reasons);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(820, 179);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(820, 217);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.TS_Reasons);
            // 
            // DGV_Reasons
            // 
            this.DGV_Reasons.AllowUserToAddRows = false;
            this.DGV_Reasons.AllowUserToDeleteRows = false;
            this.DGV_Reasons.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Reasons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Reasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Reasons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Reasons.Location = new System.Drawing.Point(0, 0);
            this.DGV_Reasons.Name = "DGV_Reasons";
            this.DGV_Reasons.ReadOnly = true;
            this.DGV_Reasons.Size = new System.Drawing.Size(820, 179);
            this.DGV_Reasons.TabIndex = 28;
            this.DGV_Reasons.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // TS_Reasons
            // 
            this.TS_Reasons.AutoSize = false;
            this.TS_Reasons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Reasons.CanOverflow = false;
            this.TS_Reasons.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Reasons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Reasons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_AddReason,
            this.TSB_EditReason,
            this.TSB_DeleteReason});
            this.TS_Reasons.Location = new System.Drawing.Point(0, 0);
            this.TS_Reasons.Name = "TS_Reasons";
            this.TS_Reasons.Size = new System.Drawing.Size(820, 38);
            this.TS_Reasons.Stretch = true;
            this.TS_Reasons.TabIndex = 27;
            this.TS_Reasons.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // TSB_AddReason
            // 
            this.TSB_AddReason.BackColor = System.Drawing.Color.LightGray;
            this.TSB_AddReason.Image = global::ServiceStation.Properties.Resources.Add;
            this.TSB_AddReason.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_AddReason.Margin = new System.Windows.Forms.Padding(20, 9, 0, 9);
            this.TSB_AddReason.Name = "TSB_AddReason";
            this.TSB_AddReason.Size = new System.Drawing.Size(79, 20);
            this.TSB_AddReason.Text = "Добавить";
            this.TSB_AddReason.Click += new System.EventHandler(this.TSB_AddReason_Click);
            // 
            // TSB_EditReason
            // 
            this.TSB_EditReason.BackColor = System.Drawing.Color.LightGray;
            this.TSB_EditReason.Image = global::ServiceStation.Properties.Resources.Edit;
            this.TSB_EditReason.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_EditReason.Margin = new System.Windows.Forms.Padding(10, 9, 0, 9);
            this.TSB_EditReason.Name = "TSB_EditReason";
            this.TSB_EditReason.Size = new System.Drawing.Size(81, 20);
            this.TSB_EditReason.Text = "Изменить";
            this.TSB_EditReason.Click += new System.EventHandler(this.TSB_EditReason_Click);
            // 
            // TSB_DeleteReason
            // 
            this.TSB_DeleteReason.BackColor = System.Drawing.Color.LightGray;
            this.TSB_DeleteReason.Image = global::ServiceStation.Properties.Resources.Basket;
            this.TSB_DeleteReason.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_DeleteReason.Margin = new System.Windows.Forms.Padding(10, 9, 0, 9);
            this.TSB_DeleteReason.Name = "TSB_DeleteReason";
            this.TSB_DeleteReason.Size = new System.Drawing.Size(71, 20);
            this.TSB_DeleteReason.Text = "Удалить";
            this.TSB_DeleteReason.Click += new System.EventHandler(this.TSB_DeleteReason_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RTB_Revealed);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(826, 223);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Выявленный ремонт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RTB_Revealed
            // 
            this.RTB_Revealed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Revealed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Revealed.Location = new System.Drawing.Point(0, 0);
            this.RTB_Revealed.MaxLength = 4000;
            this.RTB_Revealed.Name = "RTB_Revealed";
            this.RTB_Revealed.Size = new System.Drawing.Size(826, 223);
            this.RTB_Revealed.TabIndex = 29;
            this.RTB_Revealed.Text = "";
            this.RTB_Revealed.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RTB_Other);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(826, 223);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Рекомендации";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RTB_Other
            // 
            this.RTB_Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Other.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Other.Location = new System.Drawing.Point(0, 0);
            this.RTB_Other.MaxLength = 4000;
            this.RTB_Other.Name = "RTB_Other";
            this.RTB_Other.Size = new System.Drawing.Size(826, 223);
            this.RTB_Other.TabIndex = 0;
            this.RTB_Other.Text = "";
            this.RTB_Other.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // TS_SavePanel
            // 
            this.TS_SavePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_SavePanel.CanOverflow = false;
            this.TS_SavePanel.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_SavePanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_SavePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Censel});
            this.TS_SavePanel.Location = new System.Drawing.Point(0, 0);
            this.TS_SavePanel.Name = "TS_SavePanel";
            this.TS_SavePanel.Size = new System.Drawing.Size(834, 36);
            this.TS_SavePanel.Stretch = true;
            this.TS_SavePanel.TabIndex = 0;
            this.TS_SavePanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            // 
            // TSB_Save
            // 
            this.TSB_Save.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Save.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Save.Image")));
            this.TSB_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Save.Margin = new System.Windows.Forms.Padding(20, 9, 0, 7);
            this.TSB_Save.Name = "TSB_Save";
            this.TSB_Save.Size = new System.Drawing.Size(85, 20);
            this.TSB_Save.Text = "Сохранить";
            this.TSB_Save.Click += new System.EventHandler(this.TSB_Save_Click);
            // 
            // TSB_Censel
            // 
            this.TSB_Censel.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Censel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Censel.Image")));
            this.TSB_Censel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Censel.Margin = new System.Windows.Forms.Padding(10, 9, 0, 7);
            this.TSB_Censel.Name = "TSB_Censel";
            this.TSB_Censel.Size = new System.Drawing.Size(69, 20);
            this.TSB_Censel.Text = "Отмена";
            this.TSB_Censel.Click += new System.EventHandler(this.TSB_Censel_Click);
            // 
            // EditingApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "EditingApplicationForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавление заявки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingApplicationForm_PreviewKeyDown);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.TS_Total.ResumeLayout(false);
            this.TS_Total.PerformLayout();
            this.SC_DataApplication.Panel1.ResumeLayout(false);
            this.SC_DataApplication.Panel1.PerformLayout();
            this.SC_DataApplication.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_DataApplication)).EndInit();
            this.SC_DataApplication.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Options)).EndInit();
            this.TS_Options.ResumeLayout(false);
            this.TS_Options.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reasons)).EndInit();
            this.TS_Reasons.ResumeLayout(false);
            this.TS_Reasons.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.TS_SavePanel.ResumeLayout(false);
            this.TS_SavePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label L_Date;
        private System.Windows.Forms.Label L_Representative;
        private System.Windows.Forms.Label L_Number;
        private System.Windows.Forms.Label L_Counterparty;
        private System.Windows.Forms.DateTimePicker DTP_FirstControlTime;
        private System.Windows.Forms.DateTimePicker DTP_SecondControlTime;
        private System.Windows.Forms.Label L_FirstControlTime;
        private System.Windows.Forms.Label L_SecondControlTime;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer SC_DataApplication;
        private System.Windows.Forms.ToolStrip TS_SavePanel;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.Label L_Car;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.ToolStrip TS_Options;
        private System.Windows.Forms.ToolStripButton TSB_AddOption;
        private System.Windows.Forms.ToolStripButton TSB_DeleteOption;
        private System.Windows.Forms.Button B_ClearCN;
        private System.Windows.Forms.Label L_Responsible;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.Label L_Type;
        internal System.Windows.Forms.LinkLabel LL_PowerOfAttorney;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.DataGridView DGV_Reasons;
        private System.Windows.Forms.DataGridView DGV_Options;
        private System.Windows.Forms.LinkLabel LL_Car;
        private System.Windows.Forms.LinkLabel LL_Contractor;
        private System.Windows.Forms.LinkLabel LL_ContactPerson;
        private ViewOnlyTextBox.ViewOnlyTextBox TB_Number;
        private System.Windows.Forms.LinkLabel LL_Responsible;
        private System.Windows.Forms.ToolStrip TS_Reasons;
        private System.Windows.Forms.ToolStripButton TSB_AddReason;
        private System.Windows.Forms.ToolStripButton TSB_EditReason;
        private System.Windows.Forms.ToolStripButton TSB_DeleteReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox RTB_Revealed;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox RTB_Other;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_Extradition;
        private System.Windows.Forms.DateTimePicker DTP_Readiness;
        private System.Windows.Forms.ToolStrip TS_Total;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel TSL_Sum;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}