using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingUnitForm : Form, IEditingUnitView
    {

        public event ActionAsync Save;
        public event ActionAsync Loading;

        internal EditingUnitForm()
        {
            InitializeComponent();
            Load += EditingUnitForm_Load;
            TSB_Close.Click += (s, e) => Close();
            TSB_Save.Click += async (s, e) => await Save?.Invoke();
        }

        private async void EditingUnitForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_Name.Focus();
            TB_Name.SelectionStart = TB_Name.TextLength;
        }

        public int Code { get { return (int)NUD_Code.Value; } }

        public string ShortName { get { return TB_ShortName.Text; } }

        public string Title { set { this.Text = value; } }

        public string NameUnit { get { return TB_Name.Text; } }

        public void SetUnitInfo(int code, string name, string shortName)
        {
            NUD_Code.Value = code;
            TB_Name.Text = name;
            TB_ShortName.Text = shortName;
        }

        private void EditingUnitForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
