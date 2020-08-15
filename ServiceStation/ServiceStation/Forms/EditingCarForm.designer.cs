namespace ServiceStation.Forms
{
    partial class EditingCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingCarForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TB_Color = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Price = new System.Windows.Forms.NumericUpDown();
            this.NUD_Mileage = new System.Windows.Forms.NumericUpDown();
            this.L_Mileage = new System.Windows.Forms.Label();
            this.LL_Model = new System.Windows.Forms.LinkLabel();
            this.L_Color = new System.Windows.Forms.Label();
            this.DTP_Year = new System.Windows.Forms.DateTimePicker();
            this.L_Year = new System.Windows.Forms.Label();
            this.TB_NumberBody = new System.Windows.Forms.TextBox();
            this.L_Body = new System.Windows.Forms.Label();
            this.TB_NumberChassis = new System.Windows.Forms.TextBox();
            this.L_NumberChassis = new System.Windows.Forms.Label();
            this.TB_NumberEngine = new System.Windows.Forms.TextBox();
            this.L_NumberEngine = new System.Windows.Forms.Label();
            this.TB_LicensePlate = new System.Windows.Forms.TextBox();
            this.L_LicensePlate = new System.Windows.Forms.Label();
            this.L_Model = new System.Windows.Forms.Label();
            this.L_VIN = new System.Windows.Forms.Label();
            this.TB_VIN = new System.Windows.Forms.TextBox();
            this.TS_SavePanel = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mileage)).BeginInit();
            this.TS_SavePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Color);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NUD_Price);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NUD_Mileage);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Mileage);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LL_Model);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Color);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DTP_Year);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Year);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_NumberBody);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Body);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_NumberChassis);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_NumberChassis);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_NumberEngine);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_NumberEngine);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_LicensePlate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_LicensePlate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Model);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_VIN);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_VIN);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(654, 173);
            this.toolStripContainer1.ContentPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(654, 211);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_SavePanel);
            // 
            // TB_Color
            // 
            this.TB_Color.Location = new System.Drawing.Point(125, 137);
            this.TB_Color.MaxLength = 50;
            this.TB_Color.Name = "TB_Color";
            this.TB_Color.Size = new System.Drawing.Size(200, 20);
            this.TB_Color.TabIndex = 20;
            this.TB_Color.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Цена:";
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // NUD_Price
            // 
            this.NUD_Price.DecimalPlaces = 2;
            this.NUD_Price.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Price.Location = new System.Drawing.Point(550, 107);
            this.NUD_Price.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUD_Price.Name = "NUD_Price";
            this.NUD_Price.Size = new System.Drawing.Size(85, 20);
            this.NUD_Price.TabIndex = 18;
            this.NUD_Price.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // NUD_Mileage
            // 
            this.NUD_Mileage.Location = new System.Drawing.Point(125, 47);
            this.NUD_Mileage.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NUD_Mileage.Name = "NUD_Mileage";
            this.NUD_Mileage.Size = new System.Drawing.Size(200, 20);
            this.NUD_Mileage.TabIndex = 6;
            this.NUD_Mileage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_Mileage
            // 
            this.L_Mileage.AutoSize = true;
            this.L_Mileage.Location = new System.Drawing.Point(15, 50);
            this.L_Mileage.Name = "L_Mileage";
            this.L_Mileage.Size = new System.Drawing.Size(47, 13);
            this.L_Mileage.TabIndex = 5;
            this.L_Mileage.Text = "Пробег:";
            this.L_Mileage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // LL_Model
            // 
            this.LL_Model.AutoSize = true;
            this.LL_Model.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Model.Location = new System.Drawing.Point(125, 20);
            this.LL_Model.Name = "LL_Model";
            this.LL_Model.Size = new System.Drawing.Size(50, 13);
            this.LL_Model.TabIndex = 2;
            this.LL_Model.TabStop = true;
            this.LL_Model.Text = "выбрать";
            this.LL_Model.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_Color
            // 
            this.L_Color.AutoSize = true;
            this.L_Color.Location = new System.Drawing.Point(15, 140);
            this.L_Color.Name = "L_Color";
            this.L_Color.Size = new System.Drawing.Size(35, 13);
            this.L_Color.TabIndex = 19;
            this.L_Color.Text = "Цвет:";
            this.L_Color.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // DTP_Year
            // 
            this.DTP_Year.CustomFormat = "yyyy";
            this.DTP_Year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Year.Location = new System.Drawing.Point(435, 107);
            this.DTP_Year.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DTP_Year.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTP_Year.Name = "DTP_Year";
            this.DTP_Year.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTP_Year.ShowUpDown = true;
            this.DTP_Year.Size = new System.Drawing.Size(55, 20);
            this.DTP_Year.TabIndex = 16;
            this.DTP_Year.Value = new System.DateTime(2016, 2, 17, 0, 0, 0, 0);
            this.DTP_Year.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_Year
            // 
            this.L_Year.AutoSize = true;
            this.L_Year.Location = new System.Drawing.Point(350, 110);
            this.L_Year.Name = "L_Year";
            this.L_Year.Size = new System.Drawing.Size(74, 13);
            this.L_Year.TabIndex = 15;
            this.L_Year.Text = "Год выпуска:";
            this.L_Year.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // TB_NumberBody
            // 
            this.TB_NumberBody.Location = new System.Drawing.Point(125, 107);
            this.TB_NumberBody.MaxLength = 20;
            this.TB_NumberBody.Name = "TB_NumberBody";
            this.TB_NumberBody.Size = new System.Drawing.Size(200, 20);
            this.TB_NumberBody.TabIndex = 14;
            this.TB_NumberBody.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_Body
            // 
            this.L_Body.AutoSize = true;
            this.L_Body.Location = new System.Drawing.Point(15, 110);
            this.L_Body.Name = "L_Body";
            this.L_Body.Size = new System.Drawing.Size(85, 13);
            this.L_Body.TabIndex = 13;
            this.L_Body.Text = "Номер  кузова:";
            this.L_Body.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // TB_NumberChassis
            // 
            this.TB_NumberChassis.Location = new System.Drawing.Point(435, 78);
            this.TB_NumberChassis.MaxLength = 20;
            this.TB_NumberChassis.Name = "TB_NumberChassis";
            this.TB_NumberChassis.Size = new System.Drawing.Size(200, 20);
            this.TB_NumberChassis.TabIndex = 12;
            this.TB_NumberChassis.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_NumberChassis
            // 
            this.L_NumberChassis.AutoSize = true;
            this.L_NumberChassis.Location = new System.Drawing.Point(350, 80);
            this.L_NumberChassis.Name = "L_NumberChassis";
            this.L_NumberChassis.Size = new System.Drawing.Size(79, 13);
            this.L_NumberChassis.TabIndex = 11;
            this.L_NumberChassis.Text = "Номер шасси:";
            this.L_NumberChassis.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // TB_NumberEngine
            // 
            this.TB_NumberEngine.Location = new System.Drawing.Point(125, 77);
            this.TB_NumberEngine.MaxLength = 20;
            this.TB_NumberEngine.Name = "TB_NumberEngine";
            this.TB_NumberEngine.Size = new System.Drawing.Size(200, 20);
            this.TB_NumberEngine.TabIndex = 10;
            this.TB_NumberEngine.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_NumberEngine
            // 
            this.L_NumberEngine.AutoSize = true;
            this.L_NumberEngine.Location = new System.Drawing.Point(15, 80);
            this.L_NumberEngine.Name = "L_NumberEngine";
            this.L_NumberEngine.Size = new System.Drawing.Size(99, 13);
            this.L_NumberEngine.TabIndex = 9;
            this.L_NumberEngine.Text = "Номер двигателя:";
            this.L_NumberEngine.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // TB_LicensePlate
            // 
            this.TB_LicensePlate.Location = new System.Drawing.Point(435, 47);
            this.TB_LicensePlate.MaxLength = 15;
            this.TB_LicensePlate.Name = "TB_LicensePlate";
            this.TB_LicensePlate.Size = new System.Drawing.Size(200, 20);
            this.TB_LicensePlate.TabIndex = 8;
            this.TB_LicensePlate.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_LicensePlate
            // 
            this.L_LicensePlate.AutoSize = true;
            this.L_LicensePlate.Location = new System.Drawing.Point(350, 50);
            this.L_LicensePlate.Name = "L_LicensePlate";
            this.L_LicensePlate.Size = new System.Drawing.Size(66, 13);
            this.L_LicensePlate.TabIndex = 7;
            this.L_LicensePlate.Text = "Гос. номер:";
            this.L_LicensePlate.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_Model
            // 
            this.L_Model.AutoSize = true;
            this.L_Model.Location = new System.Drawing.Point(15, 20);
            this.L_Model.Name = "L_Model";
            this.L_Model.Size = new System.Drawing.Size(49, 13);
            this.L_Model.TabIndex = 1;
            this.L_Model.Text = "Модель:";
            this.L_Model.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // L_VIN
            // 
            this.L_VIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_VIN.AutoSize = true;
            this.L_VIN.Location = new System.Drawing.Point(350, 20);
            this.L_VIN.Name = "L_VIN";
            this.L_VIN.Size = new System.Drawing.Size(28, 13);
            this.L_VIN.TabIndex = 3;
            this.L_VIN.Text = "VIN:";
            this.L_VIN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            // 
            // TB_VIN
            // 
            this.TB_VIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_VIN.Location = new System.Drawing.Point(435, 17);
            this.TB_VIN.MaxLength = 17;
            this.TB_VIN.Name = "TB_VIN";
            this.TB_VIN.Size = new System.Drawing.Size(200, 20);
            this.TB_VIN.TabIndex = 4;
            this.TB_VIN.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
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
            this.TS_SavePanel.Size = new System.Drawing.Size(654, 38);
            this.TS_SavePanel.Stretch = true;
            this.TS_SavePanel.TabIndex = 0;
            this.TS_SavePanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
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
            // EditingCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 211);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingCarForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавление автотранспортного средства";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingVehicles_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mileage)).EndInit();
            this.TS_SavePanel.ResumeLayout(false);
            this.TS_SavePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_SavePanel;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.Label L_Model;
        private System.Windows.Forms.Label L_VIN;
        private System.Windows.Forms.TextBox TB_VIN;
        private System.Windows.Forms.TextBox TB_LicensePlate;
        private System.Windows.Forms.Label L_LicensePlate;
        private System.Windows.Forms.DateTimePicker DTP_Year;
        private System.Windows.Forms.Label L_Year;
        private System.Windows.Forms.TextBox TB_NumberBody;
        private System.Windows.Forms.Label L_Body;
        private System.Windows.Forms.TextBox TB_NumberChassis;
        private System.Windows.Forms.Label L_NumberChassis;
        private System.Windows.Forms.TextBox TB_NumberEngine;
        private System.Windows.Forms.Label L_NumberEngine;
        private System.Windows.Forms.Label L_Color;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.LinkLabel LL_Model;
        private System.Windows.Forms.NumericUpDown NUD_Mileage;
        private System.Windows.Forms.Label L_Mileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Price;
        private System.Windows.Forms.TextBox TB_Color;
    }
}