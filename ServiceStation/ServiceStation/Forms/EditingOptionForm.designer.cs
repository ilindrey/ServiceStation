namespace ServiceStation.Forms
{
    partial class EditingOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingOptionForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TB_FullName = new System.Windows.Forms.TextBox();
            this.L_FullName = new System.Windows.Forms.Label();
            this.TB_ShortName = new System.Windows.Forms.TextBox();
            this.L_ShortName = new System.Windows.Forms.Label();
            this.TS_Contact = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.TS_Contact.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_FullName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_FullName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_ShortName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_ShortName);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(464, 83);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(464, 121);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Contact);
            this.toolStripContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingOptionForm_PreviewKeyDown);
            // 
            // TB_FullName
            // 
            this.TB_FullName.Location = new System.Drawing.Point(145, 47);
            this.TB_FullName.MaxLength = 300;
            this.TB_FullName.Name = "TB_FullName";
            this.TB_FullName.Size = new System.Drawing.Size(300, 20);
            this.TB_FullName.TabIndex = 5;
            this.TB_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingOptionForm_PreviewKeyDown);
            // 
            // L_FullName
            // 
            this.L_FullName.AutoSize = true;
            this.L_FullName.Location = new System.Drawing.Point(15, 50);
            this.L_FullName.Name = "L_FullName";
            this.L_FullName.Size = new System.Drawing.Size(125, 13);
            this.L_FullName.TabIndex = 4;
            this.L_FullName.Text = "Полное наименование:";
            this.L_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingOptionForm_PreviewKeyDown);
            // 
            // TB_ShortName
            // 
            this.TB_ShortName.Location = new System.Drawing.Point(145, 17);
            this.TB_ShortName.MaxLength = 150;
            this.TB_ShortName.Name = "TB_ShortName";
            this.TB_ShortName.Size = new System.Drawing.Size(300, 20);
            this.TB_ShortName.TabIndex = 3;
            this.TB_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingOptionForm_PreviewKeyDown);
            // 
            // L_ShortName
            // 
            this.L_ShortName.AutoSize = true;
            this.L_ShortName.Location = new System.Drawing.Point(15, 20);
            this.L_ShortName.Name = "L_ShortName";
            this.L_ShortName.Size = new System.Drawing.Size(123, 13);
            this.L_ShortName.TabIndex = 2;
            this.L_ShortName.Text = "Краткое наимнование:";
            this.L_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingOptionForm_PreviewKeyDown);
            // 
            // TS_Contact
            // 
            this.TS_Contact.AutoSize = false;
            this.TS_Contact.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Contact.CanOverflow = false;
            this.TS_Contact.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Contact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Contact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Censel});
            this.TS_Contact.Location = new System.Drawing.Point(0, 0);
            this.TS_Contact.Name = "TS_Contact";
            this.TS_Contact.Size = new System.Drawing.Size(464, 38);
            this.TS_Contact.Stretch = true;
            this.TS_Contact.TabIndex = 1;
            this.TS_Contact.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingOptionForm_PreviewKeyDown);
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
            // EditingOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 121);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 160);
            this.MinimumSize = new System.Drawing.Size(480, 160);
            this.Name = "EditingOptionForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавление комплектации";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingOptionForm_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.TS_Contact.ResumeLayout(false);
            this.TS_Contact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox TB_FullName;
        private System.Windows.Forms.Label L_FullName;
        private System.Windows.Forms.TextBox TB_ShortName;
        private System.Windows.Forms.Label L_ShortName;
        private System.Windows.Forms.ToolStrip TS_Contact;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
    }
}