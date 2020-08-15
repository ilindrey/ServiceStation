namespace ServiceStation.Forms
{
    partial class EditingPowerOfAttorneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingPowerOfAttorneyForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.L_Data = new System.Windows.Forms.Label();
            this.TB_Number = new System.Windows.Forms.TextBox();
            this.L_Number = new System.Windows.Forms.Label();
            this.TS_PowerOfAttorney = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.TS_PowerOfAttorney.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DTP_Date);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Data);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Number);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Number);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(284, 83);
            this.toolStripContainer1.ContentPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPowerOfAttorney_PreviewKeyDown);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(284, 121);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_PowerOfAttorney);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Date.Location = new System.Drawing.Point(70, 47);
            this.DTP_Date.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(195, 20);
            this.DTP_Date.TabIndex = 5;
            this.DTP_Date.Value = new System.DateTime(2016, 2, 23, 0, 0, 0, 0);
            this.DTP_Date.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPowerOfAttorney_PreviewKeyDown);
            // 
            // L_Data
            // 
            this.L_Data.AutoSize = true;
            this.L_Data.Location = new System.Drawing.Point(15, 50);
            this.L_Data.Name = "L_Data";
            this.L_Data.Size = new System.Drawing.Size(36, 13);
            this.L_Data.TabIndex = 4;
            this.L_Data.Text = "Дата:";
            this.L_Data.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPowerOfAttorney_PreviewKeyDown);
            // 
            // TB_Number
            // 
            this.TB_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Number.Location = new System.Drawing.Point(70, 17);
            this.TB_Number.MaxLength = 10;
            this.TB_Number.Name = "TB_Number";
            this.TB_Number.Size = new System.Drawing.Size(195, 20);
            this.TB_Number.TabIndex = 3;
            this.TB_Number.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPowerOfAttorney_PreviewKeyDown);
            // 
            // L_Number
            // 
            this.L_Number.AutoSize = true;
            this.L_Number.Location = new System.Drawing.Point(15, 20);
            this.L_Number.Name = "L_Number";
            this.L_Number.Size = new System.Drawing.Size(44, 13);
            this.L_Number.TabIndex = 2;
            this.L_Number.Text = "Номер:";
            this.L_Number.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPowerOfAttorney_PreviewKeyDown);
            // 
            // TS_PowerOfAttorney
            // 
            this.TS_PowerOfAttorney.AutoSize = false;
            this.TS_PowerOfAttorney.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_PowerOfAttorney.CanOverflow = false;
            this.TS_PowerOfAttorney.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_PowerOfAttorney.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_PowerOfAttorney.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Censel});
            this.TS_PowerOfAttorney.Location = new System.Drawing.Point(0, 0);
            this.TS_PowerOfAttorney.Name = "TS_PowerOfAttorney";
            this.TS_PowerOfAttorney.Size = new System.Drawing.Size(284, 38);
            this.TS_PowerOfAttorney.Stretch = true;
            this.TS_PowerOfAttorney.TabIndex = 1;
            this.TS_PowerOfAttorney.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPowerOfAttorney_PreviewKeyDown);
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
            // EditingPowerOfAttorneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 160);
            this.MinimumSize = new System.Drawing.Size(255, 160);
            this.Name = "EditingPowerOfAttorneyForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавление доверености";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPowerOfAttorney_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.TS_PowerOfAttorney.ResumeLayout(false);
            this.TS_PowerOfAttorney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_PowerOfAttorney;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.TextBox TB_Number;
        private System.Windows.Forms.Label L_Number;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label L_Data;
    }
}