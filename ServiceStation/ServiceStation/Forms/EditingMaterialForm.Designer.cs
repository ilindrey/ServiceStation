namespace ServiceStation.Forms
{
    partial class EditingMaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingMaterialForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TSL_Sum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.NUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.L_Amount = new System.Windows.Forms.Label();
            this.NUD_Price = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LL_Material = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.TS_EditingApplication = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).BeginInit();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NUD_Amount);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Amount);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.NUD_Price);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LL_Material);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(479, 88);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(479, 151);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_EditingApplication);
            this.toolStripContainer1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
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
            this.toolStrip1.Size = new System.Drawing.Size(479, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
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
            // NUD_Amount
            // 
            this.NUD_Amount.Location = new System.Drawing.Point(335, 47);
            this.NUD_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Amount.Name = "NUD_Amount";
            this.NUD_Amount.Size = new System.Drawing.Size(120, 20);
            this.NUD_Amount.TabIndex = 7;
            this.NUD_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Amount.ValueChanged += new System.EventHandler(this.CountSum);
            this.NUD_Amount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
            // 
            // L_Amount
            // 
            this.L_Amount.AutoSize = true;
            this.L_Amount.Location = new System.Drawing.Point(250, 50);
            this.L_Amount.Name = "L_Amount";
            this.L_Amount.Size = new System.Drawing.Size(69, 13);
            this.L_Amount.TabIndex = 6;
            this.L_Amount.Text = "Количество:";
            this.L_Amount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
            // 
            // NUD_Price
            // 
            this.NUD_Price.DecimalPlaces = 2;
            this.NUD_Price.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_Price.Location = new System.Drawing.Point(100, 47);
            this.NUD_Price.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NUD_Price.Name = "NUD_Price";
            this.NUD_Price.Size = new System.Drawing.Size(120, 20);
            this.NUD_Price.TabIndex = 5;
            this.NUD_Price.ValueChanged += new System.EventHandler(this.CountSum);
            this.NUD_Price.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена:";
            this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
            // 
            // LL_Material
            // 
            this.LL_Material.AutoSize = true;
            this.LL_Material.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LL_Material.Location = new System.Drawing.Point(100, 15);
            this.LL_Material.Name = "LL_Material";
            this.LL_Material.Size = new System.Drawing.Size(50, 13);
            this.LL_Material.TabIndex = 3;
            this.LL_Material.TabStop = true;
            this.LL_Material.Text = "выбрать";
            this.LL_Material.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Material_LinkClicked);
            this.LL_Material.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Материал:";
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
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
            this.TS_EditingApplication.Size = new System.Drawing.Size(479, 38);
            this.TS_EditingApplication.Stretch = true;
            this.TS_EditingApplication.TabIndex = 1;
            this.TS_EditingApplication.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
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
            // EditingMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 151);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingMaterialForm";
            this.ShowInTaskbar = false;
            this.Text = "EditingMaterialForm";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingMaterialForm_PreviewKeyDown);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).EndInit();
            this.TS_EditingApplication.ResumeLayout(false);
            this.TS_EditingApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel TSL_Sum;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip TS_EditingApplication;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.NumericUpDown NUD_Amount;
        private System.Windows.Forms.Label L_Amount;
        private System.Windows.Forms.NumericUpDown NUD_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LL_Material;
        private System.Windows.Forms.Label label1;
    }
}