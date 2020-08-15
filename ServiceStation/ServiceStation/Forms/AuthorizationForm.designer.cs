namespace ServiceStation.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.B_OK = new System.Windows.Forms.Button();
            this.B_Cencel = new System.Windows.Forms.Button();
            this.L_Login = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_OK
            // 
            this.B_OK.AutoEllipsis = true;
            this.B_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_OK.Location = new System.Drawing.Point(220, 80);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(75, 23);
            this.B_OK.TabIndex = 4;
            this.B_OK.Text = "Ок";
            this.B_OK.UseVisualStyleBackColor = true;
            // 
            // B_Cencel
            // 
            this.B_Cencel.AutoEllipsis = true;
            this.B_Cencel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cencel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Cencel.Location = new System.Drawing.Point(300, 80);
            this.B_Cencel.Name = "B_Cencel";
            this.B_Cencel.Size = new System.Drawing.Size(75, 23);
            this.B_Cencel.TabIndex = 5;
            this.B_Cencel.Text = "Отмена";
            this.B_Cencel.UseVisualStyleBackColor = true;
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Location = new System.Drawing.Point(20, 20);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(106, 13);
            this.L_Login.TabIndex = 0;
            this.L_Login.Text = "Имя пользователя:";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(20, 50);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(48, 13);
            this.L_Password.TabIndex = 2;
            this.L_Password.Text = "Пароль:";
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(135, 19);
            this.TB_Login.MaxLength = 20;
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(240, 20);
            this.TB_Login.TabIndex = 1;
            this.TB_Login.Text = "Vladimir";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(135, 49);
            this.TB_Password.MaxLength = 20;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '●';
            this.TB_Password.Size = new System.Drawing.Size(240, 20);
            this.TB_Password.TabIndex = 3;
            this.TB_Password.Text = "123";
            // 
            // AuthorizationForm
            // 
            this.AcceptButton = this.B_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_Cencel;
            this.ClientSize = new System.Drawing.Size(394, 116);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.B_Cencel);
            this.Controls.Add(this.B_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.Button B_Cencel;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.TextBox TB_Password;
    }
}