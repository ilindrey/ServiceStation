using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{

    internal partial class EditingApplicationForm : Form, IEditingApplicationView
    {
        public event ActionAsync Save;

        public event ActionAsync AddReason;
        public event ActionAsync EditReason;
        public event ActionAsync DeleteReason;

        public event ActionAsync AddOption;
        public event ActionAsync DeleteOption;

        public event Action ClearContactPerson;
        public event Action SelectionContractor;
        public event Action SelectionContactPerson;
        public event Action SelectionCar;
        public event Action SelectionPowerOfAttorney;
        public event Action SelectionResponsible;

        public event ActionAsync Loading;

        internal EditingApplicationForm()
        {
            InitializeComponent();

            DTP_Date.Value = DateTime.Now;

            Load += EditingApplicationForm_Load;
            DGV_Reasons.MouseDoubleClick += DGV_Reasons_MouseDoubleClick;
        }

        private void DGV_Reasons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                TSB_EditReason_Click(sender, e);
        }

        private async void EditingApplicationForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            LL_Contractor.Focus();
        }

        public string Contractor { set { LL_Contractor.Text = value; } }

        public string ContactPerson { set { LL_ContactPerson.Text = value; } }
        public string PowerOfAttorney { set { LL_PowerOfAttorney.Text = value; } }

        public string Car { set { LL_Car.Text = value; } }


        public int Number
        {
            get { return int.Parse(TB_Number.Text); }
            set { TB_Number.Text = value.ToString(); }
        }

        public DateTime Date { get { return DTP_Date.Value; } set { DTP_Date.Value = value; } }

        public string TypeRepair { get { return CB_Type.Text; } set { CB_Type.Text = value; } }

        public string Title { set { this.Text = value; } }

        public DataGridView Options { get { return DGV_Options; } }

        public DataGridView Reasons { get { return DGV_Reasons; } }

        public string Responsible { set { LL_Responsible.Text = value; } }

        public DateTime? FirstControlTime
        {
            get
            {
                if (DTP_FirstControlTime.Format == DateTimePickerFormat.Custom)
                    return null;
                return DTP_FirstControlTime.Value;
            }

            set
            {
                if (value != null)
                    DTP_FirstControlTime.Value = (DateTime)value;
            }
        }

        public DateTime? SecondControlTime
        {
            get
            {
                if (DTP_SecondControlTime.Format == DateTimePickerFormat.Custom)
                    return null;
                return DTP_SecondControlTime.Value;
            }

            set
            {
                if (value != null)
                    DTP_SecondControlTime.Value = (DateTime)value;
            }
        }

        public DateTime? Readiness
        {
            get
            {
                if (DTP_Readiness.Format == DateTimePickerFormat.Custom)
                    return null;
                return DTP_Readiness.Value;
            }

            set
            {
                if (value != null)
                    DTP_Readiness.Value = (DateTime)value;
            }
        }

        public DateTime? Extradition
        {
            get
            {
                if (DTP_Extradition.Format == DateTimePickerFormat.Custom)
                    return null;
                return DTP_Extradition.Value;
            }

            set
            {
                if (value != null)
                    DTP_Extradition.Value = (DateTime)value;
            }
        }

        public string Revealed
        {
            get { return RTB_Revealed.Text; }
            set { RTB_Revealed.Text = value; }
        }

        public string Recommendations
        {
            get { return RTB_Other.Text; }
            set { RTB_Other.Text = value; }
        }

        public bool EnabledContactPerson { set { LL_ContactPerson.Enabled = value; } }
        public bool EnabledPowerOfAttorney { set { LL_PowerOfAttorney.Enabled = value; } }

        public bool EnabledCar { set { LL_Car.Enabled = value; } }

        public string Sum { set { TSL_Sum.Text = value; } }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void TSB_Censel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void TSB_AddReason_Click(object sender, EventArgs e)
        {
            await AddReason?.Invoke();
        }

        private async void TSB_EditReason_Click(object sender, EventArgs e)
        {
            await EditReason?.Invoke();
        }

        private async void TSB_DeleteReason_Click(object sender, EventArgs e)
        {
            await DeleteReason?.Invoke();
        }

        private async void TSB_AddOption_Click(object sender, EventArgs e)
        {
            await AddOption?.Invoke();
        }

        private async void TSB_DeleteOption_Click(object sender, EventArgs e)
        {
            await DeleteOption?.Invoke();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker control = (DateTimePicker)sender;
            if (control?.Format == DateTimePickerFormat.Custom)
                control.Format = DateTimePickerFormat.Long;
        }

        private void LL_Responsible_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionResponsible?.Invoke();
        }

        private void B_ClearContactPerson_Click(object sender, EventArgs e)
        {
            ClearContactPerson.Invoke();
        }

        private void LL_Contractor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionContractor?.Invoke();
        }

        private void LL_ContactPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionContactPerson?.Invoke();
        }

        private void LL_PowerOfAttorney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionPowerOfAttorney?.Invoke();
        }

        private void LL_Car_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionCar?.Invoke();
        }
        
        public void SetApplicationInfo(string contractor, string car, DateTime date, DateTime? firstControlTime, DateTime? secondControlTIme, DateTime? readiness, DateTime? extradition, string typeRepair, string revealed, string other, string responsible)
        {
            EnabledCar = true;
            Date = date;
            Contractor = contractor;
            Car = car;
            DTP_Date.Value = date;
            FirstControlTime = firstControlTime;
            SecondControlTime = secondControlTIme;
            Readiness = readiness;
            Extradition = extradition;
            TypeRepair = typeRepair;
            Revealed = revealed;
            Recommendations = other;
            Responsible = responsible;
        }

        public void SetContactPersonInfo(string contactPerson, string powerOfAttorney)
        {
            this.EnabledContactPerson = true;
            this.EnabledPowerOfAttorney = true;
            ContactPerson = contactPerson;
            PowerOfAttorney = powerOfAttorney;
        }

        private void EditingApplicationForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save?.Invoke();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}