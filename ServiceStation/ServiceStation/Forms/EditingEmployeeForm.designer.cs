namespace ServiceStation.Forms
{
    partial class EditingEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingEmployeeForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.B_DeleteUser = new System.Windows.Forms.Button();
            this.LL_Post = new System.Windows.Forms.LinkLabel();
            this.B_EditingUser = new System.Windows.Forms.Button();
            this.L_Post = new System.Windows.Forms.Label();
            this.TB_FFP = new System.Windows.Forms.TextBox();
            this.L_FFO = new System.Windows.Forms.Label();
            this.CB_Administrator = new System.Windows.Forms.CheckBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.L_Login = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.TS_Employee = new System.Windows.Forms.ToolStrip();
            this.TSB_Save = new System.Windows.Forms.ToolStripButton();
            this.TSB_Censel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.TS_Employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.B_DeleteUser);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LL_Post);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.B_EditingUser);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Post);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_FFP);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_FFO);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CB_Administrator);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Password);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TB_Username);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Login);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.L_Password);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(514, 78);
            this.toolStripContainer1.ContentPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(514, 116);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Employee);
            // 
            // B_DeleteUser
            // 
            this.B_DeleteUser.Location = new System.Drawing.Point(195, 72);
            this.B_DeleteUser.Name = "B_DeleteUser";
            this.B_DeleteUser.Size = new System.Drawing.Size(150, 23);
            this.B_DeleteUser.TabIndex = 5;
            this.B_DeleteUser.Text = "Удалить пользователя";
            this.B_DeleteUser.UseVisualStyleBackColor = true;
            this.B_DeleteUser.Visible = false;
            this.B_DeleteUser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // LL_Post
            // 
            this.LL_Post.AutoSize = true;
            this.LL_Post.Location = new System.Drawing.Point(125, 50);
            this.LL_Post.Name = "LL_Post";
            this.LL_Post.Size = new System.Drawing.Size(50, 13);
            this.LL_Post.TabIndex = 4;
            this.LL_Post.TabStop = true;
            this.LL_Post.Text = "выбрать";
            this.LL_Post.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // B_EditingUser
            // 
            this.B_EditingUser.Location = new System.Drawing.Point(348, 72);
            this.B_EditingUser.Name = "B_EditingUser";
            this.B_EditingUser.Size = new System.Drawing.Size(150, 23);
            this.B_EditingUser.TabIndex = 6;
            this.B_EditingUser.Text = "Изменить пользователя";
            this.B_EditingUser.UseVisualStyleBackColor = true;
            this.B_EditingUser.Visible = false;
            this.B_EditingUser.Click += new System.EventHandler(this.B_EditingUser_Click);
            this.B_EditingUser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // L_Post
            // 
            this.L_Post.AutoSize = true;
            this.L_Post.Location = new System.Drawing.Point(15, 50);
            this.L_Post.Name = "L_Post";
            this.L_Post.Size = new System.Drawing.Size(68, 13);
            this.L_Post.TabIndex = 3;
            this.L_Post.Text = "Должность:";
            this.L_Post.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // TB_FFP
            // 
            this.TB_FFP.Location = new System.Drawing.Point(125, 17);
            this.TB_FFP.MaxLength = 250;
            this.TB_FFP.Name = "TB_FFP";
            this.TB_FFP.Size = new System.Drawing.Size(370, 20);
            this.TB_FFP.TabIndex = 2;
            this.TB_FFP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // L_FFO
            // 
            this.L_FFO.AutoSize = true;
            this.L_FFO.Location = new System.Drawing.Point(15, 20);
            this.L_FFO.Name = "L_FFO";
            this.L_FFO.Size = new System.Drawing.Size(37, 13);
            this.L_FFO.TabIndex = 1;
            this.L_FFO.Text = "ФИО:";
            this.L_FFO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // CB_Administrator
            // 
            this.CB_Administrator.AutoSize = true;
            this.CB_Administrator.Enabled = false;
            this.CB_Administrator.Location = new System.Drawing.Point(130, 152);
            this.CB_Administrator.Name = "CB_Administrator";
            this.CB_Administrator.Size = new System.Drawing.Size(290, 17);
            this.CB_Administrator.TabIndex = 11;
            this.CB_Administrator.Text = "пользователь является администратором системы";
            this.CB_Administrator.UseVisualStyleBackColor = true;
            this.CB_Administrator.Visible = false;
            this.CB_Administrator.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // TB_Password
            // 
            this.TB_Password.Enabled = false;
            this.TB_Password.Location = new System.Drawing.Point(127, 127);
            this.TB_Password.MaxLength = 20;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '•';
            this.TB_Password.Size = new System.Drawing.Size(370, 20);
            this.TB_Password.TabIndex = 10;
            this.TB_Password.Visible = false;
            this.TB_Password.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // TB_Username
            // 
            this.TB_Username.Enabled = false;
            this.TB_Username.Location = new System.Drawing.Point(127, 97);
            this.TB_Username.MaxLength = 20;
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(370, 20);
            this.TB_Username.TabIndex = 8;
            this.TB_Username.Visible = false;
            this.TB_Username.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Enabled = false;
            this.L_Login.Location = new System.Drawing.Point(15, 100);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(106, 13);
            this.L_Login.TabIndex = 7;
            this.L_Login.Text = "Имя пользователя:";
            this.L_Login.Visible = false;
            this.L_Login.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Enabled = false;
            this.L_Password.Location = new System.Drawing.Point(15, 130);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(48, 13);
            this.L_Password.TabIndex = 9;
            this.L_Password.Text = "Пароль:";
            this.L_Password.Visible = false;
            this.L_Password.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            // 
            // TS_Employee
            // 
            this.TS_Employee.AutoSize = false;
            this.TS_Employee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TS_Employee.CanOverflow = false;
            this.TS_Employee.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Employee.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Employee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Save,
            this.TSB_Censel});
            this.TS_Employee.Location = new System.Drawing.Point(0, 0);
            this.TS_Employee.Name = "TS_Employee";
            this.TS_Employee.Size = new System.Drawing.Size(514, 38);
            this.TS_Employee.Stretch = true;
            this.TS_Employee.TabIndex = 0;
            this.TS_Employee.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
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
            // EditingEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 116);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditingEmployeeForm";
            this.ShowInTaskbar = false;
            this.Text = "EditingEmployeeForm";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EditingEmployeeForm_PreviewKeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.TS_Employee.ResumeLayout(false);
            this.TS_Employee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_Employee;
        private System.Windows.Forms.ToolStripButton TSB_Save;
        private System.Windows.Forms.ToolStripButton TSB_Censel;
        private System.Windows.Forms.Label L_Post;
        private System.Windows.Forms.TextBox TB_FFP;
        private System.Windows.Forms.Label L_FFO;
        private System.Windows.Forms.CheckBox CB_Administrator;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Button B_EditingUser;
        private System.Windows.Forms.LinkLabel LL_Post;
        private System.Windows.Forms.Button B_DeleteUser;
    }
}