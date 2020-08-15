using System;
using System.Windows.Forms;
using ServiceStation.InterfacesView;

namespace ServiceStation.Forms
{
    internal partial class EditingWorkingHourForm : Form, IEditingWorkingHourView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;

        public EditingWorkingHourForm()
        {
            InitializeComponent();
            Load += EditingWorkingHourForm_Load;
        }

        private async void EditingWorkingHourForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_Name.Focus();
            TB_Name.SelectionStart = TB_Name.TextLength;
        }

        public decimal Price { get { return NUD_Price.Value; } }

        public string NameWorkingHour { get { return TB_Name.Text; } }

        public string Title { set { this.Text = value; } }

        public void SetWorkingHourInfo(string name, decimal price)
        {
            TB_Name.Text = name;
            NUD_Price.Value = price;
        }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void TSB_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditingWorkingHourForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
