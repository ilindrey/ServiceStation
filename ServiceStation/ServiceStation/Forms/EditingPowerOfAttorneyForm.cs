using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingPowerOfAttorneyForm : Form, IEditingPowerOfAttorneyView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;

        internal EditingPowerOfAttorneyForm()
        {
            InitializeComponent();

            TSB_Censel.Click += (s, e) => Close();

            TSB_Save.Click += async (s, e) => await Save?.Invoke();

            Load += EditingPowerOfAttorneyForm_Load;

            DTP_Date.Value = DateTime.Now;
        }

        private async void EditingPowerOfAttorneyForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_Number.Focus();
            TB_Number.SelectionStart = TB_Number.TextLength;
        }

        public DateTime Date { get { return DTP_Date.Value; } }
        public string Number { get { return TB_Number.Text; } }
        public string Title { set { this.Text = value; } }

        private void EditingPowerOfAttorney_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        public void SetPowerOfAttorneyInfo(string number, DateTime date)
        {
            TB_Number.Text = number;
            DTP_Date.Value = date;
        }
    }
}