using System;
using System.Threading;
using System.Windows.Forms;
using ServiceStation.InterfacesView;

namespace ServiceStation.Forms
{
    internal partial class AuthorizationForm : Form, IAuthorizationView
    {
        public event ActionAsync Login;
        public event ActionAsync Loading;

        internal AuthorizationForm()
        {
            InitializeComponent();

            TB_Login.SelectionStart = TB_Login.TextLength;

            B_Cencel.Click += btnCencel_Click;
            B_OK.Click += btnOK_Click;
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            bool createdNew;
            Mutex M = new Mutex(true, "Login", out createdNew);
            if (!createdNew) return;

            await Login?.Invoke();

            GC.KeepAlive(M);
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string Password { get { return TB_Password.Text; } }
        public string Username { get { return TB_Login.Text; } }

        public string Title { set { this.Text = value; } }
    }
}
