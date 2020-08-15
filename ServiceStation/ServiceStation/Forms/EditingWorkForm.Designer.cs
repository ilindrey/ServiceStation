namespace ServiceStation.Forms
{
    partial class EditingWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingWorkForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TSL_Sum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NUD_NormOfTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.L_Price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LL_WorkingHour = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LL_Work = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.TS_EditingApplication = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NormOfTime)).BeginInit();
            this.TS_EditingApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(494, 143);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(494, 206);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_EditingApplication);
            this.toolStripContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TSL_Sum,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(494, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Всего:";
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NUD_Amount);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.NUD_NormOfTime);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.L_Price);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.LL_WorkingHour);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.LL_Work);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(494, 143);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // NUD_Amount
            // 
            this.NUD_Amount.Location = new System.Drawing.Point(350, 103);
            this.NUD_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Amount.Name = "NUD_Amount";
            this.NUD_Amount.Size = new System.Drawing.Size(120, 20);
            this.NUD_Amount.TabIndex = 12;
            this.NUD_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Amount.ValueChanged += new System.EventHandler(this.CountSum);
            this.NUD_Amount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество:";
            this.label5.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // NUD_NormOfTime
            // 
            this.NUD_NormOfTime.DecimalPlaces = 2;
            this.NUD_NormOfTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.NUD_NormOfTime.Location = new System.Drawing.Point(125, 103);
            this.NUD_NormOfTime.Name = "NUD_NormOfTime";
            this.NUD_NormOfTime.Size = new System.Drawing.Size(120, 20);
            this.NUD_NormOfTime.TabIndex = 10;
            this.NUD_NormOfTime.ValueChanged += new System.EventHandler(this.CountSum);
            this.NUD_NormOfTime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Норма времени:";
            this.label4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // L_Price
            // 
            this.L_Price.AutoSize = true;
            this.L_Price.Location = new System.Drawing.Point(125, 75);
            this.L_Price.Name = "L_Price";
            this.L_Price.Size = new System.Drawing.Size(51, 13);
            this.L_Price.TabIndex = 8;
            this.L_Price.Text = "0 рублей";
            this.L_Price.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена Н/Ч:";
            this.label3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // LL_WorkingHour
            // 
            this.LL_WorkingHour.AutoSize = true;
            this.LL_WorkingHour.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_WorkingHour.Location = new System.Drawing.Point(125, 45);
            this.LL_WorkingHour.Name = "LL_WorkingHour";
            this.LL_WorkingHour.Size = new System.Drawing.Size(50, 13);
            this.LL_WorkingHour.TabIndex = 6;
            this.LL_WorkingHour.TabStop = true;
            this.LL_WorkingHour.Text = "выбрать";
            this.LL_WorkingHour.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_WorkingHour_LinkClicked);
            this.LL_WorkingHour.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Нормо-час:";
            this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // LL_Work
            // 
            this.LL_Work.AutoSize = true;
            this.LL_Work.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Work.Location = new System.Drawing.Point(125, 15);
            this.LL_Work.Name = "LL_Work";
            this.LL_Work.Size = new System.Drawing.Size(50, 13);
            this.LL_Work.TabIndex = 4;
            this.LL_Work.TabStop = true;
            this.LL_Work.Text = "выбрать";
            this.LL_Work.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Work_LinkClicked);
            this.LL_Work.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Работа:";
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            // 
            // TS_EditingApplication
            // 
            this.TS_EditingApplication.AutoSize = false;
            this.TS_EditingApplication.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_EditingApplication.CanOverflow = false;
            this.TS_EditingApplication.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_EditingApplication.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_EditingApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Censel});
            this.TS_EditingApplication.Location = new System.Drawing.Point(0, 0);
            this.TS_EditingApplication.Name = "TS_EditingApplication";
            this.TS_EditingApplication.Size = new System.Drawing.Size(494, 38);
            this.TS_EditingApplication.Stretch = true;
            this.TS_EditingApplication.TabIndex = 2;
            this.TS_EditingApplication.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
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
            this.TSB_Save.Click += new System.EventHandler(this.TSB_Save_Click);
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
            this.TSB_Censel.Click += new System.EventHandler(this.TSB_Censel_Click);
            // 
            // EditingWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 206);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingWorkForm";
            this.ShowInTaskbar = false;
            this.Text = "EditingWorkForm";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingWorkForm_PreviewKeyDown);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NormOfTime)).EndInit();
            this.TS_EditingApplication.ResumeLayout(false);
            this.TS_EditingApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_EditingApplication;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel TSL_Sum;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel LL_WorkingHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LL_Work;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUD_NormOfTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_Price;
        private System.Windows.Forms.Label label3;
    }
}