namespace ServiceStation.Forms
{
    partial class JournalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalsForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.DGV_Journal = new System.Windows.Forms.DataGridView();
            this.TS_Journals = new System.Windows.Forms.ToolStrip();
            this.TSB_Choose = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.TSB_Delete = new System.Windows.Forms.ToolStripButton();
            this.TSB_Change = new System.Windows.Forms.ToolStripButton();
            this.TSB_Add = new System.Windows.Forms.ToolStripButton();
            this.TSB_Update = new System.Windows.Forms.ToolStripButton();
            this.TSL_Seach = new System.Windows.Forms.ToolStripLabel();
            this.tstbSeach = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Journal)).BeginInit();
            this.TS_Journals.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DGV_Journal);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(984, 422);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(984, 461);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Journals);
            // 
            // DGV_Journal
            // 
            this.DGV_Journal.AllowUserToAddRows = false;
            this.DGV_Journal.AllowUserToDeleteRows = false;
            this.DGV_Journal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Journal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Journal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Journal.Location = new System.Drawing.Point(0, 0);
            this.DGV_Journal.Name = "DGV_Journal";
            this.DGV_Journal.ReadOnly = true;
            this.DGV_Journal.Size = new System.Drawing.Size(984, 422);
            this.DGV_Journal.TabIndex = 1;
            this.DGV_Journal.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Journals_PreviewKeyDown);
            // 
            // TS_Journals
            // 
            this.TS_Journals.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Journals.CanOverflow = false;
            this.TS_Journals.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Journals.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Journals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Choose,
            this.TSB_Censel,
            this.TSB_Delete,
            this.TSB_Change,
            this.TSB_Add,
            this.TSB_Update,
            this.TSL_Seach,
            this.tstbSeach});
            this.TS_Journals.Location = new System.Drawing.Point(0, 0);
            this.TS_Journals.Name = "TS_Journals";
            this.TS_Journals.Size = new System.Drawing.Size(984, 39);
            this.TS_Journals.Stretch = true;
            this.TS_Journals.TabIndex = 0;
            this.TS_Journals.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Journals_PreviewKeyDown);
            // 
            // TSB_Choose
            // 
            this.TSB_Choose.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Choose.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Choose.Image")));
            this.TSB_Choose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Choose.Margin = new System.Windows.Forms.Padding(20, 9, 0, 10);
            this.TSB_Choose.Name = "TSB_Choose";
            this.TSB_Choose.Size = new System.Drawing.Size(74, 20);
            this.TSB_Choose.Text = "Выбрать";
            this.TSB_Choose.Click += new System.EventHandler(this.TSB_Choose_Click);
            // 
            // TSB_Censel
            // 
            this.TSB_Censel.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Censel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Censel.Image")));
            this.TSB_Censel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Censel.Margin = new System.Windows.Forms.Padding(10, 9, 0, 10);
            this.TSB_Censel.Name = "TSB_Censel";
            this.TSB_Censel.Size = new System.Drawing.Size(69, 20);
            this.TSB_Censel.Text = "Отмена";
            // 
            // TSB_Delete
            // 
            this.TSB_Delete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSB_Delete.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Delete.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Delete.Image")));
            this.TSB_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Delete.Margin = new System.Windows.Forms.Padding(10, 9, 10, 10);
            this.TSB_Delete.Name = "TSB_Delete";
            this.TSB_Delete.Size = new System.Drawing.Size(71, 20);
            this.TSB_Delete.Text = "Удалить";
            this.TSB_Delete.Click += new System.EventHandler(this.TSB_Delete_Click);
            // 
            // TSB_Change
            // 
            this.TSB_Change.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSB_Change.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Change.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Change.Image")));
            this.TSB_Change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Change.Margin = new System.Windows.Forms.Padding(10, 9, 0, 10);
            this.TSB_Change.Name = "TSB_Change";
            this.TSB_Change.Size = new System.Drawing.Size(81, 20);
            this.TSB_Change.Text = "Изменить";
            this.TSB_Change.Click += new System.EventHandler(this.TSB_Change_Click);
            // 
            // TSB_Add
            // 
            this.TSB_Add.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSB_Add.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Add.Image")));
            this.TSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Add.Margin = new System.Windows.Forms.Padding(10, 9, 0, 10);
            this.TSB_Add.Name = "TSB_Add";
            this.TSB_Add.Size = new System.Drawing.Size(79, 20);
            this.TSB_Add.Text = "Добавить";
            this.TSB_Add.Click += new System.EventHandler(this.TSB_Add_Click);
            // 
            // TSB_Update
            // 
            this.TSB_Update.BackColor = System.Drawing.Color.LightGray;
            this.TSB_Update.Image = global::ServiceStation.Properties.Resources.Update;
            this.TSB_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Update.Margin = new System.Windows.Forms.Padding(50, 9, 0, 10);
            this.TSB_Update.Name = "TSB_Update";
            this.TSB_Update.Size = new System.Drawing.Size(81, 20);
            this.TSB_Update.Text = "Обновить";
            this.TSB_Update.ToolTipText = "Обновить журнал";
            // 
            // TSL_Seach
            // 
            this.TSL_Seach.Margin = new System.Windows.Forms.Padding(50, 9, 0, 10);
            this.TSL_Seach.Name = "TSL_Seach";
            this.TSL_Seach.Size = new System.Drawing.Size(45, 20);
            this.TSL_Seach.Text = "Поиск:";
            // 
            // tstbSeach
            // 
            this.tstbSeach.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.tstbSeach.Name = "tstbSeach";
            this.tstbSeach.Size = new System.Drawing.Size(250, 29);
            // 
            // JournalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 300);
            this.Name = "JournalsForm";
            this.ShowInTaskbar = false;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Journals_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Journal)).EndInit();
            this.TS_Journals.ResumeLayout(false);
            this.TS_Journals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView DGV_Journal;
        private System.Windows.Forms.ToolStrip TS_Journals;
        private System.Windows.Forms.ToolStripButton TSB_Choose;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.ToolStripButton TSB_Delete;
        private System.Windows.Forms.ToolStripButton TSB_Change;
        private System.Windows.Forms.ToolStripButton TSB_Add;
        private System.Windows.Forms.ToolStripButton TSB_Update;
        private System.Windows.Forms.ToolStripLabel TSL_Seach;
        private System.Windows.Forms.ToolStripTextBox tstbSeach;
    }
}