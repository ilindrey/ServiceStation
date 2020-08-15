using ServiceStation.InterfacesView;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingEmployeeForm : Form, IEditingEmployeeView
    {
        private bool _existsUser;

        public event Action SelectionPost;

        public event ActionAsync Save;
        public event ActionAsync DeleteUser;
        public event ActionAsync Loading;
        

        public EditingEmployeeForm()
        {
            InitializeComponent();

            B_DeleteUser.Click += B_DeleteUser_Click;

            TSB_Censel.Click += (s, e) => Close();

            LL_Post.Click += (s, e) => SelectionPost?.Invoke();

            TSB_Save.Click += async (s, e) => await Save?.Invoke();

            Load += EditingEmployeeForm_Load;

        }

        private async void EditingEmployeeForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_FFP.Focus();
            TB_FFP.SelectionStart = TB_FFP.TextLength;
        }

        private async void B_DeleteUser_Click(object sender, EventArgs e)
        {
            await DeleteUser?.Invoke();
        }

        public bool EnterUser { get; set; }
        public bool Administrator { get { return CB_Administrator.Checked; } }

        public string FFP { get { return TB_FFP.Text; } }

        public string Password { get { return TB_Password.Text; } }

        public string Post { get { return LL_Post.Text; } set { LL_Post.Text = value; } }

        public string Title { set { this.Text = value; } }

        public string Username { get { return TB_Username.Text; } }

        public bool VisibleDeleteUser
        {
            set
            {
                _existsUser = value;
                B_DeleteUser.Visible = value;
            }
        }

        public Button EditingUser { get { return B_EditingUser; } }

        public void SetEmployeeInfo(string FFP, string post)
        {
            TB_FFP.Text = FFP;
            LL_Post.Text = post;
        }

        public void SetUserInfo(string username, string password, bool administrator)
        {
            TB_Username.Text = username;
            TB_Password.Text = password;
            CB_Administrator.Checked = administrator;
            B_EditingUser.PerformClick();
        }

        private void B_EditingUser_Click(object sender, EventArgs e)
        {
            if (!EnterUser)
            {
                B_EditingUser.Text = "Отменить изменения";

                if (_existsUser)
                    B_DeleteUser.Visible = true;

                L_Login.Visible = true;
                L_Password.Visible = true;

                TB_Username.Visible = true;
                TB_Password.Visible = true;

                CB_Administrator.Visible = true;
                
                L_Login.Enabled = true;
                L_Password.Enabled = true;

                TB_Username.Enabled = true;
                TB_Password.Enabled = true;

                CB_Administrator.Enabled = true;

                ClientSize = new Size(519, 221);

                EnterUser = true;
            }
            else
            {
                B_EditingUser.Text = "Изменить пользователя";

                B_DeleteUser.Visible = false;

                L_Login.Visible = false;
                L_Password.Visible = false;
                TB_Username.Visible = false;
                TB_Password.Visible = false;
                CB_Administrator.Visible = false;

                L_Login.Enabled = false;
                L_Password.Enabled = false;

                TB_Username.Enabled = false;
                TB_Password.Enabled = false;

                CB_Administrator.Enabled = false;

                ClientSize = new Size(519, 146);

                EnterUser = false;
            }
        }

        private void EditingEmployeeForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                SelectionPost?.Invoke();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                TSB_Save.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
