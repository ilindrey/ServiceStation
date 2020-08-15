using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingMarkForm : Form, IEditingMarkView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;

        internal EditingMarkForm()
        {
            InitializeComponent();
            Load += EditingMarkForm_Load;
        }

        private async void EditingMarkForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_ShortName.Focus();
            TB_ShortName.SelectionStart = TB_ShortName.TextLength;
        }
        
        public string FullName
        {
            get { return TB_FullName.Text; }
        }

        public string ShortName
        {
            get { return TB_ShortName.Text; }
        }

        public string Title
        {
            set { this.Text = value; }
        }

        public void SetMarkInfo(string shortName, string fullName)
        {
            TB_ShortName.Text = shortName;
            TB_FullName.Text = fullName;
        }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void TSB_Censel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditingMarkForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TSB_Save.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
