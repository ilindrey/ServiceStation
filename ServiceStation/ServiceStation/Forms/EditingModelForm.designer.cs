namespace ServiceStation.Forms
{
    partial class EditingModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingModelForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.LL_Mark = new System.Windows.Forms.LinkLabel();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.L_Mark = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LL_Mark);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Name);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Mark);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Name);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(484, 78);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(484, 116);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Contact);
            // 
            // LL_Mark
            // 
            this.LL_Mark.AutoSize = true;
            this.LL_Mark.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Mark.Location = new System.Drawing.Point(140, 50);
            this.LL_Mark.Name = "LL_Mark";
            this.LL_Mark.Size = new System.Drawing.Size(50, 13);
            this.LL_Mark.TabIndex = 4;
            this.LL_Mark.TabStop = true;
            this.LL_Mark.Text = "выбрать";
            this.LL_Mark.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingModelForm_PreviewKeyDown);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(140, 17);
            this.TB_Name.MaxLength = 150;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(325, 20);
            this.TB_Name.TabIndex = 2;
            this.TB_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingModelForm_PreviewKeyDown);
            // 
            // L_Mark
            // 
            this.L_Mark.AutoSize = true;
            this.L_Mark.Location = new System.Drawing.Point(15, 50);
            this.L_Mark.Name = "L_Mark";
            this.L_Mark.Size = new System.Drawing.Size(107, 13);
            this.L_Mark.TabIndex = 3;
            this.L_Mark.Text = "Марка автомобиля:";
            this.L_Mark.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingModelForm_PreviewKeyDown);
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(15, 20);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(86, 13);
            this.L_Name.TabIndex = 1;
            this.L_Name.Text = "Наименование:";
            this.L_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingModelForm_PreviewKeyDown);
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
            this.TS_Contact.Size = new System.Drawing.Size(484, 38);
            this.TS_Contact.Stretch = true;
            this.TS_Contact.TabIndex = 0;
            this.TS_Contact.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingModelForm_PreviewKeyDown);
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
            // EditingModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 116);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingModelForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавление модели";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingModelForm_PreviewKeyDown);
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
        private System.Windows.Forms.ToolStrip TS_Contact;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label L_Mark;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.LinkLabel LL_Mark;
    }
}