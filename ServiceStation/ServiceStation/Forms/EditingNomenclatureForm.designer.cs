namespace ServiceStation.Forms
{
    partial class EditingNomenclatureForm
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
            System.Windows.Forms.Label L_ShortName;
            System.Windows.Forms.Label L_FullName;
            System.Windows.Forms.Label L_Code;
            System.Windows.Forms.Label L_Type;
            System.Windows.Forms.Label L_UnitOfMeasurement;
            System.Windows.Forms.Label L_VendorCode;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingNomenclatureForm));
            this.L_Price = new System.Windows.Forms.Label();
            this.RB_Good = new System.Windows.Forms.RadioButton();
            this.TB_ShortName = new System.Windows.Forms.TextBox();
            this.TB_FullName = new System.Windows.Forms.TextBox();
            this.RB_Work = new System.Windows.Forms.RadioButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TB_Number = new ViewOnlyTextBox.ViewOnlyTextBox();
            this.LL_Unit = new System.Windows.Forms.LinkLabel();
            this.NUD_Price = new System.Windows.Forms.NumericUpDown();
            this.TB_VendorCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.TS_EditingHomenclature = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            L_ShortName = new System.Windows.Forms.Label();
            L_FullName = new System.Windows.Forms.Label();
            L_Code = new System.Windows.Forms.Label();
            L_Type = new System.Windows.Forms.Label();
            L_UnitOfMeasurement = new System.Windows.Forms.Label();
            L_VendorCode = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TS_EditingHomenclature.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_ShortName
            // 
            L_ShortName.AutoSize = true;
            L_ShortName.Location = new System.Drawing.Point(15, 17);
            L_ShortName.Name = "L_ShortName";
            L_ShortName.Size = new System.Drawing.Size(129, 13);
            L_ShortName.TabIndex = 2;
            L_ShortName.Text = "Краткое наименование:";
            L_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // L_FullName
            // 
            L_FullName.AutoSize = true;
            L_FullName.Location = new System.Drawing.Point(15, 47);
            L_FullName.Name = "L_FullName";
            L_FullName.Size = new System.Drawing.Size(125, 13);
            L_FullName.TabIndex = 6;
            L_FullName.Text = "Полное наименование:";
            L_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // L_Code
            // 
            L_Code.AutoSize = true;
            L_Code.Location = new System.Drawing.Point(480, 17);
            L_Code.Name = "L_Code";
            L_Code.Size = new System.Drawing.Size(44, 13);
            L_Code.TabIndex = 4;
            L_Code.Text = "Номер:";
            L_Code.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // L_Type
            // 
            L_Type.AutoSize = true;
            L_Type.Location = new System.Drawing.Point(15, 77);
            L_Type.Name = "L_Type";
            L_Type.Size = new System.Drawing.Size(106, 13);
            L_Type.TabIndex = 8;
            L_Type.Text = "Тип номенклатуры:";
            L_Type.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // L_UnitOfMeasurement
            // 
            L_UnitOfMeasurement.AutoSize = true;
            L_UnitOfMeasurement.Location = new System.Drawing.Point(15, 107);
            L_UnitOfMeasurement.Name = "L_UnitOfMeasurement";
            L_UnitOfMeasurement.Size = new System.Drawing.Size(112, 13);
            L_UnitOfMeasurement.TabIndex = 11;
            L_UnitOfMeasurement.Text = "Единица измерения:";
            L_UnitOfMeasurement.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // L_VendorCode
            // 
            L_VendorCode.AutoSize = true;
            L_VendorCode.Location = new System.Drawing.Point(15, 137);
            L_VendorCode.Name = "L_VendorCode";
            L_VendorCode.Size = new System.Drawing.Size(51, 13);
            L_VendorCode.TabIndex = 15;
            L_VendorCode.Text = "Артикул:";
            L_VendorCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // L_Price
            // 
            this.L_Price.AutoSize = true;
            this.L_Price.Location = new System.Drawing.Point(345, 107);
            this.L_Price.Name = "L_Price";
            this.L_Price.Size = new System.Drawing.Size(83, 13);
            this.L_Price.TabIndex = 13;
            this.L_Price.Text = "Цена продажи:";
            this.L_Price.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // RB_Good
            // 
            this.RB_Good.AutoSize = true;
            this.RB_Good.Checked = true;
            this.RB_Good.Location = new System.Drawing.Point(150, 77);
            this.RB_Good.Name = "RB_Good";
            this.RB_Good.Size = new System.Drawing.Size(56, 17);
            this.RB_Good.TabIndex = 9;
            this.RB_Good.TabStop = true;
            this.RB_Good.Text = "Товар";
            this.RB_Good.UseVisualStyleBackColor = true;
            this.RB_Good.CheckedChanged += new System.EventHandler(this.RB_Good_CheckedChanged);
            this.RB_Good.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // TB_ShortName
            // 
            this.TB_ShortName.Location = new System.Drawing.Point(150, 15);
            this.TB_ShortName.MaxLength = 150;
            this.TB_ShortName.Name = "TB_ShortName";
            this.TB_ShortName.Size = new System.Drawing.Size(320, 20);
            this.TB_ShortName.TabIndex = 3;
            this.TB_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // TB_FullName
            // 
            this.TB_FullName.Location = new System.Drawing.Point(150, 45);
            this.TB_FullName.MaxLength = 300;
            this.TB_FullName.Name = "TB_FullName";
            this.TB_FullName.Size = new System.Drawing.Size(480, 20);
            this.TB_FullName.TabIndex = 7;
            this.TB_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // RB_Work
            // 
            this.RB_Work.AutoSize = true;
            this.RB_Work.Location = new System.Drawing.Point(230, 77);
            this.RB_Work.Name = "RB_Work";
            this.RB_Work.Size = new System.Drawing.Size(61, 17);
            this.RB_Work.TabIndex = 10;
            this.RB_Work.Text = "Работа";
            this.RB_Work.UseVisualStyleBackColor = true;
            this.RB_Work.CheckedChanged += new System.EventHandler(this.RB_Work_CheckedChanged);
            this.RB_Work.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Number);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LL_Unit);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NUD_Price);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Price);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_UnitOfMeasurement);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_VendorCode);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_VendorCode);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_ShortName);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_Type);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_ShortName);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_FullName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_FullName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.RB_Work);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_Code);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.RB_Good);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(649, 331);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(649, 371);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_EditingHomenclature);
            this.toolStripContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // TB_Number
            // 
            this.TB_Number.Cursor = System.Windows.Forms.Cursors.Default;
            this.TB_Number.Location = new System.Drawing.Point(531, 17);
            this.TB_Number.Name = "TB_Number";
            this.TB_Number.Size = new System.Drawing.Size(100, 20);
            this.TB_Number.TabIndex = 5;
            this.TB_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Number.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // LL_Unit
            // 
            this.LL_Unit.AutoSize = true;
            this.LL_Unit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Unit.Location = new System.Drawing.Point(150, 107);
            this.LL_Unit.Name = "LL_Unit";
            this.LL_Unit.Size = new System.Drawing.Size(50, 13);
            this.LL_Unit.TabIndex = 12;
            this.LL_Unit.TabStop = true;
            this.LL_Unit.Text = "выбрать";
            this.LL_Unit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // NUD_Price
            // 
            this.NUD_Price.DecimalPlaces = 2;
            this.NUD_Price.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_Price.Location = new System.Drawing.Point(465, 105);
            this.NUD_Price.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NUD_Price.Name = "NUD_Price";
            this.NUD_Price.Size = new System.Drawing.Size(165, 20);
            this.NUD_Price.TabIndex = 14;
            this.NUD_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_Price.ThousandsSeparator = true;
            this.NUD_Price.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // TB_VendorCode
            // 
            this.TB_VendorCode.Location = new System.Drawing.Point(150, 134);
            this.TB_VendorCode.MaxLength = 20;
            this.TB_VendorCode.Name = "TB_VendorCode";
            this.TB_VendorCode.Size = new System.Drawing.Size(150, 20);
            this.TB_VendorCode.TabIndex = 16;
            this.TB_VendorCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RTB_Description);
            this.groupBox1.Location = new System.Drawing.Point(15, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 149);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание";
            this.groupBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // RTB_Description
            // 
            this.RTB_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Description.Location = new System.Drawing.Point(3, 16);
            this.RTB_Description.MaxLength = 4000;
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(609, 130);
            this.RTB_Description.TabIndex = 18;
            this.RTB_Description.Text = "";
            this.RTB_Description.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // TS_EditingHomenclature
            // 
            this.TS_EditingHomenclature.AutoSize = false;
            this.TS_EditingHomenclature.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_EditingHomenclature.CanOverflow = false;
            this.TS_EditingHomenclature.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_EditingHomenclature.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_EditingHomenclature.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Censel});
            this.TS_EditingHomenclature.Location = new System.Drawing.Point(0, 0);
            this.TS_EditingHomenclature.Name = "TS_EditingHomenclature";
            this.TS_EditingHomenclature.Size = new System.Drawing.Size(649, 40);
            this.TS_EditingHomenclature.Stretch = true;
            this.TS_EditingHomenclature.TabIndex = 1;
            this.TS_EditingHomenclature.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            // 
            // TSB_Save
            // 
            this.TSB_Save.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Save.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Save.Image")));
            this.TSB_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Save.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.TSB_Save.Name = "TSB_Save";
            this.TSB_Save.Size = new System.Drawing.Size(85, 20);
            this.TSB_Save.Text = "Сохранить";
            // 
            // TSB_Censel
            // 
            this.TSB_Censel.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Censel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Censel.Image")));
            this.TSB_Censel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Censel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.TSB_Censel.Name = "TSB_Censel";
            this.TSB_Censel.Size = new System.Drawing.Size(69, 20);
            this.TSB_Censel.Text = "Отмена";
            // 
            // EditingNomenclatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 371);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingNomenclatureForm";
            this.ShowInTaskbar = false;
            this.Text = "Редактирование номенклатуры";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingNomenclatureForm_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.TS_EditingHomenclature.ResumeLayout(false);
            this.TS_EditingHomenclature.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton RB_Good;
        private System.Windows.Forms.TextBox TB_ShortName;
        private System.Windows.Forms.TextBox TB_FullName;
        private System.Windows.Forms.RadioButton RB_Work;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_EditingHomenclature;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.NumericUpDown NUD_Price;
        private System.Windows.Forms.TextBox TB_VendorCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.LinkLabel LL_Unit;
        private ViewOnlyTextBox.ViewOnlyTextBox TB_Number;
        private System.Windows.Forms.Label L_Price;
    }
}