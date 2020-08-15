namespace ServiceStation.Forms
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.EH_DocumentViewer = new System.Windows.Forms.Integration.ElementHost();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EH_DocumentViewer
            // 
            this.EH_DocumentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EH_DocumentViewer.Location = new System.Drawing.Point(0, 0);
            this.EH_DocumentViewer.Name = "EH_DocumentViewer";
            this.EH_DocumentViewer.Size = new System.Drawing.Size(634, 461);
            this.EH_DocumentViewer.TabIndex = 5;
            this.EH_DocumentViewer.Child = null;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWaiting.Location = new System.Drawing.Point(250, 215);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(129, 24);
            this.lblWaiting.TabIndex = 6;
            this.lblWaiting.Text = "Ожидайте.....";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.EH_DocumentViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintForm";
            this.ShowInTaskbar = false;
            this.Text = "Печать документа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost EH_DocumentViewer;
        private System.Windows.Forms.Label lblWaiting;
    }
}