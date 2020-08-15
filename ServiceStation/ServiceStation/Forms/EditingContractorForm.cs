using ServiceStation.InterfacesView;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingContractorForm : Form, IEditingContractorView
    {

        public event ActionAsync Save;
        public event ActionAsync Loading;

        public event ActionAsync AddCar;
        public event ActionAsync EditCar;
        public event ActionAsync DeleteCar;

        public event ActionAsync AddContactPerson;
        public event ActionAsync EditContactPerson;
        public event ActionAsync DeleteContactPerson;

        internal EditingContractorForm()
        {
            InitializeComponent();

            TSB_Censel.Click += (s, e) => Close();

            TSB_Save.Click += async (s, e) => await Save?.Invoke();

            TSB_AddV.Click += async (s, e) => await AddCar?.Invoke();
            TSB_EditV.Click += async (s, e) => await EditCar?.Invoke();
            TSB_RemoveV.Click += async (s, e) => await DeleteCar?.Invoke();

            TSB_AddCN.Click += async (s, e) => await AddContactPerson?.Invoke();
            TSB_EditCN.Click += async (s, e) => await EditContactPerson?.Invoke();
            TSB_RemoveCN.Click += async (s, e) => await DeleteContactPerson?.Invoke();

            DGV_Cars.MouseDoubleClick += async (s, e) => { if (e.Button == MouseButtons.Left) await EditCar?.Invoke(); };
            DGV_ContactPersones.MouseDoubleClick += async (s, e) => { if (e.Button == MouseButtons.Left) await EditContactPerson?.Invoke(); };

            Load += EditingContractorForm_Load;
        }

        private async void EditingContractorForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            CB_View.Focus();
        }

        public string View { get { return CB_View.Text; } }
        public string ShortName { get { return TB_ShortName.Text; } }
        public string FullName { get { return TB_FullName.Text; } }
        public string INN { get { return TB_INN.Text; } }
        public string KPP { get { return TB_KPP.Text; } }
        public string OKPO { get { return TB_OKPO.Text; } }
        public string Phone { get { return TB_Phone.Text; } }
        public string Email { get { return TB_Email.Text; } }
        public string Additionally { get { return RTB_Additionally.Text; } }
        public string Title { set { this.Text = value; } }
        public string Address { get { return TB_Address.Text; } }
        public DataGridView CarsJournal { get { return DGV_Cars; } }
        public DataGridView ContactPersonJournal { get { return DGV_ContactPersones; } }

        private void CB_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_View.Text == CB_View.Items[1].ToString())
            {
                L_OKPO.Location = new Point(15, 47);
                L_Phone.Location = new Point(15, 77);
                L_Email.Location = new Point(15, 107);
                L_Address.Location = new Point(15, 137);

                TB_OKPO.Location = new Point(120, 45);
                TB_Phone.Location = new Point(120, 75);
                TB_Email.Location = new Point(120, 105);
                TB_Address.Location = new Point(120, 135);

                L_KPP.Enabled = false;
                L_KPP.Visible = false;

                TB_KPP.Text = null;
                TB_KPP.Enabled = false;
                TB_KPP.Visible = false;
            }
            else if (CB_View.Text == CB_View.Items[0].ToString())
            {
                L_KPP.Enabled = true;
                L_KPP.Visible = true;

                TB_KPP.Enabled = true;
                TB_KPP.Visible = true;


                L_OKPO.Location = new Point(15, 77);
                L_Phone.Location = new Point(15, 107);
                L_Email.Location = new Point(15, 137);
                L_Address.Location = new Point(15, 167);

                TB_OKPO.Location = new Point(120, 75);
                TB_Phone.Location = new Point(120, 105);
                TB_Email.Location = new Point(120, 135);
                TB_Address.Location = new Point(120, 165);
            }
        }




        public void SetСontractorInfo(string view, string shortName, string fullName, string INN, string KPP, string OKPO, string phone, string email,string address, string additionally)
        {
            CB_View.Text = view;
            TB_ShortName.Text = shortName;
            TB_FullName.Text = fullName;
            TB_INN.Text = INN;
            TB_KPP.Text = KPP;
            TB_OKPO.Text = OKPO;
            TB_Phone.Text = phone;
            TB_Email.Text = email;
            TB_Address.Text = address;
            RTB_Additionally.Text = additionally;
        }

        private void EditingContractorForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
