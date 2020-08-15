using System;
using System.Windows.Forms;
using ServiceStation.InterfacesView;

namespace ServiceStation.Forms
{
    internal partial class EditingCarForm : Form, IEditingCarView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;

        public event Action SelectionModel;

        internal EditingCarForm()
        {
            InitializeComponent();

            DTP_Year.Value = DateTime.Now;


            Load += EditingCarForm_Load;

            TSB_Censel.Click += (s, e) => Close();

            LL_Model.Click += (s, e) => SelectionModel?.Invoke();

            TSB_Save.Click += async (s, e) => await Save?.Invoke();
            
        }

        private async void EditingCarForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            LL_Model.Focus();
        }

        public string LicensePlate { get { return TB_LicensePlate.Text; } }

        public string NameModel { set { LL_Model.Text = value; } }

        public string NumberBody { get { return TB_NumberBody.Text; } }

        public string NumberChassis { get { return TB_NumberChassis.Text; } }

        public string NumberEngine { get { return TB_NumberEngine.Text; } }

        public string Title { set { this.Text = value; } }

        public string VIN
        {
            get
            {
                if (TB_VIN.TextLength != TB_VIN.MaxLength)
                    return null;
                return TB_VIN.Text;
            }
        }

        public DateTime Year { get { return DTP_Year.Value; } }

        public decimal Mileage { get { return NUD_Mileage.Value; } }

        public string Color { get { return TB_Color.Text; } }

        public decimal Price { get { return NUD_Price.Value; } }


        public void SetCarInfo(string nameModel, string VIN, decimal mileage, string licensePlate, string numberEngine, string numberChassis, string numberBody, DateTime year, string color, decimal price)
        {
            LL_Model.Text = nameModel;
            TB_VIN.Text = VIN;
            TB_LicensePlate.Text = licensePlate;
            NUD_Mileage.Value = mileage;
            TB_NumberEngine.Text = numberEngine;
            TB_NumberChassis.Text = numberChassis;
            TB_NumberBody.Text = numberBody;
            DTP_Year.Value = year;
            TB_Color.Text = color;
            NUD_Price.Value = price;
        }

        private void EditingVehicles_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                SelectionModel?.Invoke();
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