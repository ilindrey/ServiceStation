using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingWorkForm : Form, IEditingWorkView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;


        public event Action CalculateSum;
        public event Action SelectionNomenclature;
        public event Action SelectionWorkingHour;


        public EditingWorkForm()
        {
            InitializeComponent();
            Load += EditingWorkForm_Load;
        }


        private async void EditingWorkForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            LL_Work.Focus();
        }


        public int Amount { get { return (int)NUD_Amount.Value; } set { NUD_Amount.Value = value; } }

        public string NameWorkingHour { set { LL_WorkingHour.Text = value; } }

        public string Nomenclature { set { LL_Work.Text = value; } }

        public decimal NormOfTime { get { return NUD_NormOfTime.Value; } set { NUD_NormOfTime.Value = value; } }
    
        public string PriceWorkingHour { set { L_Price.Text = value; } }

        public string Sum { set { TSL_Sum.Text = value; } }

        public string Title { set { this.Text = value; } }


        private void CountSum(object sender, EventArgs e)
        {
            CalculateSum?.Invoke();
        }

        private void LL_Work_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionNomenclature?.Invoke();
        }

        private void LL_WorkingHour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionWorkingHour?.Invoke();
        }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void TSB_Censel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetWorkInfo(string nomenclature, int amount, string nameWorkingHour, string priceWorkingHour, decimal normOfTime)
        {
            LL_Work.Text = nomenclature;
            NUD_Amount.Value = amount;
            LL_WorkingHour.Text = nameWorkingHour;
            L_Price.Text = priceWorkingHour;
            NUD_NormOfTime.Value = normOfTime;
        }

        private void EditingWorkForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter && (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1))
            {
                SelectionNomenclature?.Invoke();
            }
            else if (e.Control && e.KeyCode == Keys.Enter && (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2))
            {
                SelectionWorkingHour?.Invoke();
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
