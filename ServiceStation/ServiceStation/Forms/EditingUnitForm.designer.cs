namespace ServiceStation.Forms
{
    partial class EditingUnitForm
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
            System.Windows.Forms.Label L_Name;
            System.Windows.Forms.Label L_Code;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingUnitForm));
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_ShortName = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.NUD_Code = new System.Windows.Forms.NumericUpDown();
            this.TS_AddingUnits = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Close = new System.Windows.Forms.ToolStripButton();
            L_ShortName = new System.Windows.Forms.Label();
            L_Name = new System.Windows.Forms.Label();
            L_Code = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Code)).BeginInit();
            this.TS_AddingUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_ShortName
            // 
            L_ShortName.AutoSize = true;
            L_ShortName.Location = new System.Drawing.Point(15, 47);
            L_ShortName.Name = "L_ShortName";
            L_ShortName.Size = new System.Drawing.Size(157, 13);
            L_ShortName.TabIndex = 6;
            L_ShortName.Text = "Сокращенное наименование:";
            L_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            // 
            // L_Name
            // 
            L_Name.AutoSize = true;
            L_Name.Location = new System.Drawing.Point(15, 20);
            L_Name.Name = "L_Name";
            L_Name.Size = new System.Drawing.Size(86, 13);
            L_Name.TabIndex = 2;
            L_Name.Text = "Наименование:";
            L_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            // 
            // L_Code
            // 
            L_Code.AutoSize = true;
            L_Code.Location = new System.Drawing.Point(390, 20);
            L_Code.Name = "L_Code";
            L_Code.Size = new System.Drawing.Size(29, 13);
            L_Code.TabIndex = 4;
            L_Code.Text = "Код:";
            L_Code.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(105, 17);
            this.TB_Name.MaxLength = 40;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(270, 20);
            this.TB_Name.TabIndex = 3;
            this.TB_Name.WordWrap = false;
            this.TB_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            // 
            // TB_ShortName
            // 
            this.TB_ShortName.Location = new System.Drawing.Point(175, 45);
            this.TB_ShortName.MaxLength = 40;
            this.TB_ShortName.Name = "TB_ShortName";
            this.TB_ShortName.Size = new System.Drawing.Size(370, 20);
            this.TB_ShortName.TabIndex = 7;
            this.TB_ShortName.WordWrap = false;
            this.TB_ShortName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NUD_Code);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_Code);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_Name);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Name);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_ShortName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_ShortName);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(564, 81);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(564, 121);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_AddingUnits);
            this.toolStripContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            // 
            // NUD_Code
            // 
            this.NUD_Code.Location = new System.Drawing.Point(425, 17);
            this.NUD_Code.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_Code.Name = "NUD_Code";
            this.NUD_Code.Size = new System.Drawing.Size(120, 20);
            this.NUD_Code.TabIndex = 5;
            this.NUD_Code.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            // 
            // TS_AddingUnits
            // 
            this.TS_AddingUnits.AutoSize = false;
            this.TS_AddingUnits.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_AddingUnits.CanOverflow = false;
            this.TS_AddingUnits.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_AddingUnits.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_AddingUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Close});
            this.TS_AddingUnits.Location = new System.Drawing.Point(0, 0);
            this.TS_AddingUnits.Name = "TS_AddingUnits";
            this.TS_AddingUnits.Size = new System.Drawing.Size(564, 40);
            this.TS_AddingUnits.Stretch = true;
            this.TS_AddingUnits.TabIndex = 1;
            this.TS_AddingUnits.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
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
            // TSB_Close
            // 
            this.TSB_Close.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Close.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Close.Image")));
            this.TSB_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Close.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.TSB_Close.Name = "TSB_Close";
            this.TSB_Close.Size = new System.Drawing.Size(69, 20);
            this.TSB_Close.Text = "Отмена";
            // 
            // EditingUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 121);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingUnitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование единицы измерения";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingUnitForm_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Code)).EndInit();
            this.TS_AddingUnits.ResumeLayout(false);
            this.TS_AddingUnits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_ShortName;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_AddingUnits;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Close;
        private System.Windows.Forms.NumericUpDown NUD_Code;
    }
}