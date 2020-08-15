using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingContactPersonForm : Form, IEditingContactPersonView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;
        public event ActionAsync AddPowerOfAttorney;
        public event ActionAsync EditPowerOfAttorney;
        public event ActionAsync DeletePowerOfAttorney;

        internal EditingContactPersonForm()
        {
            InitializeComponent();
            Load += EditingContactPersonForm_Load;
            TSB_Censel.Click += (s, e) => Close();

            TSB_Save.Click +=  async (s, e) => await Save?.Invoke();
            TSB_Add.Click += async (s, e) => await AddPowerOfAttorney?.Invoke();
            TSB_Edit.Click += async (s, e) => await EditPowerOfAttorney?.Invoke();
            TSB_Remove.Click += async (s, e) => await DeletePowerOfAttorney?.Invoke();

            DGV_PowerOfAttorney.MouseDoubleClick += DGV_PowerOfAttorney_MouseDoubleClick;
        }

        private async void DGV_PowerOfAttorney_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                await EditPowerOfAttorney?.Invoke();
        }

        private async void EditingContactPersonForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_FFP.Focus();
            TB_FFP.SelectionStart = TB_FFP.TextLength;
        }

        public string Additionally { get { return RTB_Additionly.Text; } }
        public string Email { get { return TB_Email.Text; } }
        public string FFP { get { return TB_FFP.Text; } }
        public string Phone { get { return TB_Phone.Text; } }
        public string Title { set { this.Text = value; } }
        public DataGridView PowerOfAttorneyJournal { get { return DGV_PowerOfAttorney; } }

        public string Address { get { return TB_Address.Text; } }

        public void SetContactNameInfo(string FFP, string phone, string email, string address, string additionaly)
        {
            TB_FFP.Text = FFP;
            TB_Phone.Text = phone;
            TB_Email.Text = email;
            TB_Address.Text = address;
            RTB_Additionly.Text = additionaly;
        }

        private void EditingContactPersonForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    TSB_Save.PerformClick();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
