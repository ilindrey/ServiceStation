using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingMaterialForm : Form, IEditingMaterialView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;

        public event Action CalculateSum;
        public event Action SelectionNomenclature;


        public EditingMaterialForm()
        {
            InitializeComponent();

            Load += EditingMaterialForm_Load;
        }

        private async void EditingMaterialForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            LL_Material.Focus();
        }

        public int Amount
        {
            get { return (int)NUD_Amount.Value; }
            set { NUD_Amount.Value = value; }
        }

        public string Nomenclature { set { LL_Material.Text = value; } }

        public decimal Price
        {
            get { return NUD_Price.Value; }
            set { NUD_Price.Value = value; }
        }

        public string Sum { set { TSL_Sum.Text = value; } }

        public string Title { set { this.Text = value; } }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void TSB_Censel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LL_Material_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionNomenclature?.Invoke();
        }

        private void CountSum(object sender, EventArgs e)
        {
            CalculateSum?.Invoke();
        }

        public void SetMaterialInfo(string nameNomenclature, int amount, decimal price)
        {
            LL_Material.Text = nameNomenclature;
            NUD_Amount.Value = amount;
            NUD_Price.Value = price;
        }

        private void EditingMaterialForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                SelectionNomenclature?.Invoke();
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
