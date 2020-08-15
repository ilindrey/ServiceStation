namespace ServiceStation.Forms
{
    partial class EditingReasonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingReasonForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.GB_Additionly = new System.Windows.Forms.GroupBox();
            this.RTB_Additionally = new System.Windows.Forms.RichTextBox();
            this.TB_FullName = new System.Windows.Forms.TextBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.L_Type = new System.Windows.Forms.Label();
            this.L_FullName = new System.Windows.Forms.Label();
            this.TB_ShortName = new System.Windows.Forms.TextBox();
            this.L_ShortName = new System.Windows.Forms.Label();
            this.TS_Contact = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.GB_Additionly.SuspendLayout();
            this.TS_Contact.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.GB_Additionly);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_FullName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CB_Type);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Type);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_FullName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_ShortName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_ShortName);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(684, 163);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(684, 201);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Contact);
            this.toolStripContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // GB_Additionly
            // 
            this.GB_Additionly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Additionly.Controls.Add(this.RTB_Additionally);
            this.GB_Additionly.Location = new System.Drawing.Point(15, 75);
            this.GB_Additionly.Name = "GB_Additionly";
            this.GB_Additionly.Size = new System.Drawing.Size(655, 75);
            this.GB_Additionly.TabIndex = 8;
            this.GB_Additionly.TabStop = false;
            this.GB_Additionly.Text = "Дополнительно";
            this.GB_Additionly.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // RTB_Additionally
            // 
            this.RTB_Additionally.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Additionally.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Additionally.Location = new System.Drawing.Point(3, 16);
            this.RTB_Additionally.MaxLength = 4000;
            this.RTB_Additionally.Name = "RTB_Additionally";
            this.RTB_Additionally.Size = new System.Drawing.Size(649, 51);
            this.RTB_Additionally.TabIndex = 9;
            this.RTB_Additionally.Text = "";
            this.RTB_Additionally.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // TB_FullName
            // 
            this.TB_FullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_FullName.Location = new System.Drawing.Point(145, 47);
            this.TB_FullName.MaxLength = 200;
            this.TB_FullName.Name = "TB_FullName";
            this.TB_FullName.Size = new System.Drawing.Size(525, 20);
            this.TB_FullName.TabIndex = 7;
            this.TB_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // CB_Type
            // 
            this.CB_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "внешнее",
            "втуреннее"});
            this.CB_Type.Location = new System.Drawing.Point(559, 17);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(110, 21);
            this.CB_Type.TabIndex = 5;
            this.CB_Type.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // L_Type
            // 
            this.L_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Type.AutoSize = true;
            this.L_Type.Location = new System.Drawing.Point(460, 20);
            this.L_Type.Name = "L_Type";
            this.L_Type.Size = new System.Drawing.Size(92, 13);
            this.L_Type.TabIndex = 4;
            this.L_Type.Text = "Тип проявления:";
            this.L_Type.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // L_FullName
            // 
            this.L_FullName.AutoSize = true;
            this.L_FullName.Location = new System.Drawing.Point(15, 50);
            this.L_FullName.Name = "L_FullName";
            this.L_FullName.Size = new System.Drawing.Size(125, 13);
            this.L_FullName.TabIndex = 6;
            this.L_FullName.Text = "Полное наименование:";
            this.L_FullName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // TB_ShortName
            // 
            this.TB_ShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ShortName.Location = new System.Drawing.Point(145, 17);
            this.TB_ShortName.MaxLength = 100;
            this.TB_ShortName.Name = "TB_ShortName";
            this.TB_ShortName.Size = new System.Drawing.Size(300, 20);
            this.TB_ShortName.TabIndex = 3;
            this.TB_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            // 
            // L_ShortName
            // 
            this.L_ShortName.AutoSize = true;
            this.L_ShortName.Location = new System.Drawing.Point(15, 20);
            this.L_ShortName.Name = "L_ShortName";
            this.L_ShortName.Size = new System.Drawing.Size(123, 13);
            this.L_ShortName.TabIndex = 2;
            this.L_ShortName.Text = "Краткое наимнование:";
            this.L_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
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
            this.TS_Contact.Size = new System.Drawing.Size(684, 38);
            this.TS_Contact.Stretch = true;
            this.TS_Contact.TabIndex = 1;
            this.TS_Contact.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
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
            // EditingReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 201);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 240);
            this.Name = "EditingReasonForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавление причины обращения";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingReasons_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.GB_Additionly.ResumeLayout(false);
            this.TS_Contact.ResumeLayout(false);
            this.TS_Contact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_Contact;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.Label L_ShortName;
        private System.Windows.Forms.Label L_FullName;
        private System.Windows.Forms.TextBox TB_ShortName;
        private System.Windows.Forms.Label L_Type;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.GroupBox GB_Additionly;
        private System.Windows.Forms.RichTextBox RTB_Additionally;
        private System.Windows.Forms.TextBox TB_FullName;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
    }
}