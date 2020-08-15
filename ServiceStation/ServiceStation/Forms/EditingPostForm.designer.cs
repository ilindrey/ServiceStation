namespace ServiceStation.Forms
{
    partial class EditingPostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingPostForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TB_Post = new System.Windows.Forms.TextBox();
            this.L_Post = new System.Windows.Forms.Label();
            this.TS_Post = new System.Windows.Forms.ToolStrip();
            this.TSP_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.TS_Post.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Post);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Post);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(419, 53);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(419, 91);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Post);
            // 
            // TB_Post
            // 
            this.TB_Post.Location = new System.Drawing.Point(86, 17);
            this.TB_Post.MaxLength = 200;
            this.TB_Post.Name = "TB_Post";
            this.TB_Post.Size = new System.Drawing.Size(310, 20);
            this.TB_Post.TabIndex = 3;
            this.TB_Post.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPost_PreviewKeyDown);
            // 
            // L_Post
            // 
            this.L_Post.AutoSize = true;
            this.L_Post.Location = new System.Drawing.Point(15, 20);
            this.L_Post.Name = "L_Post";
            this.L_Post.Size = new System.Drawing.Size(68, 13);
            this.L_Post.TabIndex = 2;
            this.L_Post.Text = "Должность:";
            this.L_Post.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPost_PreviewKeyDown);
            // 
            // TS_Post
            // 
            this.TS_Post.AutoSize = false;
            this.TS_Post.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Post.CanOverflow = false;
            this.TS_Post.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Post.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Post.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSP_Save,
            this.TSB_Censel});
            this.TS_Post.Location = new System.Drawing.Point(0, 0);
            this.TS_Post.Name = "TS_Post";
            this.TS_Post.Size = new System.Drawing.Size(419, 38);
            this.TS_Post.Stretch = true;
            this.TS_Post.TabIndex = 1;
            this.TS_Post.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPost_PreviewKeyDown);
            // 
            // TSP_Save
            // 
            this.TSP_Save.BackColor = System.Drawing.Color.LightGray;
            this.TSP_Save.Image = ((System.Drawing.Image)(resources.GetObject("TSP_Save.Image")));
            this.TSP_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSP_Save.Margin = new System.Windows.Forms.Padding(20, 9, 0, 9);
            this.TSP_Save.Name = "TSP_Save";
            this.TSP_Save.Size = new System.Drawing.Size(85, 20);
            this.TSP_Save.Text = "Сохранить";
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
            // EditingPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 91);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingPostForm";
            this.ShowInTaskbar = false;
            this.Text = "Редактирование должности";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingPost_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.TS_Post.ResumeLayout(false);
            this.TS_Post.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox TB_Post;
        private System.Windows.Forms.Label L_Post;
        private System.Windows.Forms.ToolStrip TS_Post;
        private System.Windows.Forms.ToolStripButton TSP_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
    }
}