namespace ServiceStation.Forms
{
    partial class EditingContactPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingContactPersonForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.L_Phone = new System.Windows.Forms.Label();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.L_Email = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.DGV_PowerOfAttorney = new System.Windows.Forms.DataGridView();
            this.TS_PowerOfAttorneys = new System.Windows.Forms.ToolStrip();
            this.TSB_Add = new System.Windows.Forms.ToolStripButton();
            this.TSB_Edit = new System.Windows.Forms.ToolStripButton();
            this.TSB_Remove = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RTB_Additionly = new System.Windows.Forms.RichTextBox();
            this.L_FFO = new System.Windows.Forms.Label();
            this.TB_FFP = new System.Windows.Forms.TextBox();
            this.TS_SavePanel = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PowerOfAttorney)).BeginInit();
            this.TS_PowerOfAttorneys.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.TS_SavePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_FFO);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_FFP);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(479, 246);
            this.toolStripContainer1.ContentPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(479, 286);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_SavePanel);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 185);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TB_Address);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TB_Email);
            this.tabPage1.Controls.Add(this.L_Phone);
            this.tabPage1.Controls.Add(this.TB_Phone);
            this.tabPage1.Controls.Add(this.L_Email);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Контактная информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(130, 77);
            this.TB_Address.MaxLength = 100;
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(200, 20);
            this.TB_Address.TabIndex = 9;
            this.TB_Address.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Адрес:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(130, 15);
            this.TB_Email.MaxLength = 40;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(200, 20);
            this.TB_Email.TabIndex = 5;
            this.TB_Email.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Location = new System.Drawing.Point(15, 47);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(55, 13);
            this.L_Phone.TabIndex = 6;
            this.L_Phone.Text = "Телефон:";
            this.L_Phone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(130, 45);
            this.TB_Phone.MaxLength = 11;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(200, 20);
            this.TB_Phone.TabIndex = 7;
            this.TB_Phone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // L_Email
            // 
            this.L_Email.AutoSize = true;
            this.L_Email.Location = new System.Drawing.Point(15, 17);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(38, 13);
            this.L_Email.TabIndex = 4;
            this.L_Email.Text = "E-mail:";
            this.L_Email.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStripContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доверености";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.DGV_PowerOfAttorney);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(436, 113);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(436, 153);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.TS_PowerOfAttorneys);
            // 
            // DGV_PowerOfAttorney
            // 
            this.DGV_PowerOfAttorney.AllowUserToAddRows = false;
            this.DGV_PowerOfAttorney.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_PowerOfAttorney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_PowerOfAttorney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PowerOfAttorney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PowerOfAttorney.Location = new System.Drawing.Point(0, 0);
            this.DGV_PowerOfAttorney.Name = "DGV_PowerOfAttorney";
            this.DGV_PowerOfAttorney.ReadOnly = true;
            this.DGV_PowerOfAttorney.Size = new System.Drawing.Size(436, 113);
            this.DGV_PowerOfAttorney.TabIndex = 11;
            this.DGV_PowerOfAttorney.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // TS_PowerOfAttorneys
            // 
            this.TS_PowerOfAttorneys.AutoSize = false;
            this.TS_PowerOfAttorneys.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_PowerOfAttorneys.CanOverflow = false;
            this.TS_PowerOfAttorneys.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_PowerOfAttorneys.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_PowerOfAttorneys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Add,
            this.TSB_Edit,
            this.TSB_Remove});
            this.TS_PowerOfAttorneys.Location = new System.Drawing.Point(0, 0);
            this.TS_PowerOfAttorneys.Name = "TS_PowerOfAttorneys";
            this.TS_PowerOfAttorneys.Size = new System.Drawing.Size(436, 40);
            this.TS_PowerOfAttorneys.Stretch = true;
            this.TS_PowerOfAttorneys.TabIndex = 10;
            this.TS_PowerOfAttorneys.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // TSB_Add
            // 
            this.TSB_Add.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Add.Image")));
            this.TSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Add.Margin = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.TSB_Add.Name = "TSB_Add";
            this.TSB_Add.Size = new System.Drawing.Size(79, 20);
            this.TSB_Add.Text = "Добавить";
            // 
            // TSB_Edit
            // 
            this.TSB_Edit.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Edit.Image")));
            this.TSB_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Edit.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.TSB_Edit.Name = "TSB_Edit";
            this.TSB_Edit.Size = new System.Drawing.Size(81, 20);
            this.TSB_Edit.Text = "Изменить";
            // 
            // TSB_Remove
            // 
            this.TSB_Remove.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Remove.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Remove.Image")));
            this.TSB_Remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Remove.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.TSB_Remove.Name = "TSB_Remove";
            this.TSB_Remove.Size = new System.Drawing.Size(71, 20);
            this.TSB_Remove.Text = "Удалить";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RTB_Additionly);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(442, 159);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Дополнительно";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RTB_Additionly
            // 
            this.RTB_Additionly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Additionly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Additionly.Location = new System.Drawing.Point(3, 3);
            this.RTB_Additionly.MaxLength = 4000;
            this.RTB_Additionly.Name = "RTB_Additionly";
            this.RTB_Additionly.Size = new System.Drawing.Size(436, 153);
            this.RTB_Additionly.TabIndex = 12;
            this.RTB_Additionly.Text = "";
            this.RTB_Additionly.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // L_FFO
            // 
            this.L_FFO.AutoSize = true;
            this.L_FFO.Location = new System.Drawing.Point(15, 17);
            this.L_FFO.Name = "L_FFO";
            this.L_FFO.Size = new System.Drawing.Size(37, 13);
            this.L_FFO.TabIndex = 1;
            this.L_FFO.Text = "ФИО:";
            this.L_FFO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            // 
            // TB_FFP
            // 
            this.TB_FFP.Location = new System.Drawing.Point(60, 15);
            this.TB_FFP.MaxLength = 250;
            this.TB_FFP.Name = "TB_FFP";
            this.TB_FFP.Size = new System.Drawing.Size(400, 20);
            this.TB_FFP.TabIndex = 2;
            this.TB_FFP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
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
            this.TS_SavePanel.Size = new System.Drawing.Size(479, 40);
            this.TS_SavePanel.Stretch = true;
            this.TS_SavePanel.TabIndex = 0;
            this.TS_SavePanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
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
            // EditingContactPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 286);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(495, 325);
            this.Name = "EditingContactPersonForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавление контактного лица";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingContactPersonForm_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PowerOfAttorney)).EndInit();
            this.TS_PowerOfAttorneys.ResumeLayout(false);
            this.TS_PowerOfAttorneys.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.TS_SavePanel.ResumeLayout(false);
            this.TS_SavePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_SavePanel;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label L_FFO;
        private System.Windows.Forms.TextBox TB_FFP;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.DataGridView DGV_PowerOfAttorney;
        private System.Windows.Forms.RichTextBox RTB_Additionly;
        private System.Windows.Forms.ToolStrip TS_PowerOfAttorneys;
        private System.Windows.Forms.ToolStripButton TSB_Add;
        private System.Windows.Forms.ToolStripButton TSB_Edit;
        private System.Windows.Forms.ToolStripButton TSB_Remove;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label label1;
    }
}