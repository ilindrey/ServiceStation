using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingOptionForm : Form, IEditingOptionView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;

        internal EditingOptionForm()
        {
            InitializeComponent();
            Load += EditingOptionForm_Load;
            TSB_Save.Click += TSB_Save_Click;
            TSB_Censel.Click += TSB_Censel_Click; ;
        }

        private async void EditingOptionForm_Load(object sender, EventArgs e)
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

        public string ShortName { get { return TB_ShortName.Text; } }

        public string FullName { get { return TB_FullName.Text; } }

        public string Title { set { this.Text = value; } }

        public void SetOptionInfo(string shortName, string fullName)
        {
            TB_ShortName.Text = shortName;
            TB_FullName.Text = fullName;
        }

        private void EditingOptionForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
