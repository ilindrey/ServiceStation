namespace ServiceStation.Forms
{
    partial class EditingWorkingHourForm
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
            System.Windows.Forms.Label L_Name;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingWorkingHourForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.NUD_Price = new System.Windows.Forms.NumericUpDown();
            this.L_Price = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TS_Units = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Close = new System.Windows.Forms.ToolStripButton();
            L_Name = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).BeginInit();
            this.TS_Units.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Name
            // 
            L_Name.AutoSize = true;
            L_Name.Location = new System.Drawing.Point(15, 20);
            L_Name.Name = "L_Name";
            L_Name.Size = new System.Drawing.Size(86, 13);
            L_Name.TabIndex = 2;
            L_Name.Text = "Наименование:";
            L_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkingHourForm_PreviewKeyDown);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NUD_Price);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Price);
            this.toolStripContainer1.ContentPanel.Controls.Add(L_Name);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Name);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(624, 51);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(624, 91);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Units);
            this.toolStripContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkingHourForm_PreviewKeyDown);
            // 
            // NUD_Price
            // 
            this.NUD_Price.DecimalPlaces = 2;
            this.NUD_Price.Location = new System.Drawing.Point(504, 17);
            this.NUD_Price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_Price.Name = "NUD_Price";
            this.NUD_Price.Size = new System.Drawing.Size(100, 20);
            this.NUD_Price.TabIndex = 5;
            this.NUD_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_Price.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkingHourForm_PreviewKeyDown);
            // 
            // L_Price
            // 
            this.L_Price.AutoSize = true;
            this.L_Price.Location = new System.Drawing.Point(465, 20);
            this.L_Price.Name = "L_Price";
            this.L_Price.Size = new System.Drawing.Size(36, 13);
            this.L_Price.TabIndex = 4;
            this.L_Price.Text = "Цена:";
            this.L_Price.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkingHourForm_PreviewKeyDown);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(105, 17);
            this.TB_Name.MaxLength = 100;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(350, 20);
            this.TB_Name.TabIndex = 3;
            this.TB_Name.WordWrap = false;
            this.TB_Name.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkingHourForm_PreviewKeyDown);
            // 
            // TS_Units
            // 
            this.TS_Units.AutoSize = false;
            this.TS_Units.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Units.CanOverflow = false;
            this.TS_Units.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Units.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Units.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Close});
            this.TS_Units.Location = new System.Drawing.Point(0, 0);
            this.TS_Units.Name = "TS_Units";
            this.TS_Units.Size = new System.Drawing.Size(624, 40);
            this.TS_Units.Stretch = true;
            this.TS_Units.TabIndex = 1;
            this.TS_Units.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkingHourForm_PreviewKeyDown);
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
            this.TSB_Save.Click += new System.EventHandler(this.TSB_Save_Click);
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
            this.TSB_Close.Click += new System.EventHandler(this.TSB_Close_Click);
            // 
            // EditingWorkingHourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 91);
            this.Controls.Add(this.toolStripContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingWorkingHourForm";
            this.ShowInTaskbar = false;
            this.Text = "Редактирование нормо-часа";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkingHourForm_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).EndInit();
            this.TS_Units.ResumeLayout(false);
            this.TS_Units.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_Units;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Close;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.NumericUpDown NUD_Price;
        private System.Windows.Forms.Label L_Price;
    }
}