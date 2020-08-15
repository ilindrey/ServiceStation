using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingNomenclatureForm : Form, IEditingNomenclatureView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;


        public event Action SelectionUnit;

        
        internal EditingNomenclatureForm()
        {
            InitializeComponent();

            Load += EditingNomenclatureForm_Load;

            TSB_Censel.Click += TSB_Censel_Click;

            TSB_Save.Click += TSB_Save_Click;

            LL_Unit.Click += LL_Unit_Click;
        }


        private async void EditingNomenclatureForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_ShortName.Focus();
            TB_ShortName.SelectionStart = TB_ShortName.TextLength;
        }

        private void TSB_Censel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void LL_Unit_Click(object sender, EventArgs e)
        {
            SelectionUnit?.Invoke();
        }


        internal RadioButton Good { get { return RB_Good; } }
        internal RadioButton Work { get { return RB_Work; } }


        public string Descriprion { get { return RTB_Description.Text; } }

        public string FullName { get { return TB_FullName.Text; } }

        public string NameUnit { set { LL_Unit.Text = value; } }
        
        public int Number
        {
            get { return int.Parse(TB_Number.Text); }
            set { TB_Number.Text = value.ToString(); }
        }

        public decimal Price { get { return NUD_Price.Value; } }

        public string ShortName { get { return TB_ShortName.Text; } }

        public string Title { set { this.Text = value; } }

        public string Type
        {
            get
            {
                if (RB_Good.Checked)
                {
                    return RB_Good.Text;
                }
                else
                {
                    return RB_Work.Text;
                }
            }
        }

        public string VendorCode { get { return TB_VendorCode.Text; } }


        public void SetNomenclatureInfo(int number, string shortName, string fullName, string type, string nameUnit, string vendorCode, decimal price, string descriprion)
        {

            Number = number;
            TB_ShortName.Text = shortName;
            TB_FullName.Text = fullName;
            switch (type)
            {
                case "Работа":
                    RB_Work.Checked = true;
                    L_Price.Text = "Время выполнения:";
                    break;
                case "Товар":
                    RB_Good.Checked = true;
                    L_Price.Text = "Цена продажи:";
                    NUD_Price.Maximum = 10000000000;
                    NUD_Price.Increment = 5m;
                    break;
            }
            LL_Unit.Text = nameUnit;
            TB_VendorCode.Text = vendorCode;
            NUD_Price.Value = price;
            RTB_Description.Text = descriprion;
        }

        private void RB_Good_CheckedChanged(object sender, EventArgs e)
        {
            L_Price.Text = "Цена продажи:";
            NUD_Price.Maximum = 10000000000;
            NUD_Price.Increment = 5m;
        }

        private void RB_Work_CheckedChanged(object sender, EventArgs e)
        {
            L_Price.Text = "Время выполнения:";
            NUD_Price.Maximum = 100;
            NUD_Price.Increment = 0.10m;
        }

        private void EditingNomenclatureForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                SelectionUnit?.Invoke();
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
