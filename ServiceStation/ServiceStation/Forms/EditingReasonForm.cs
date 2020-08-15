using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingReasonForm : Form, IEditingReasonView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;

        internal EditingReasonForm()
        {
            InitializeComponent();
            Load += EditingReasonForm_Load;
            TSB_Censel.Click += TSB_Censel_Click;
            TSB_Save.Click += TSB_Save_Click;
        }

        private async void EditingReasonForm_Load(object sender, EventArgs e)
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

        public string Additionally { get { return RTB_Additionally.Text; } }

        public string FullName { get { return TB_FullName.Text; } }

        public string ShortName { get { return TB_ShortName.Text; } }

        public string TypeManifestation { get { return CB_Type.Text; } }

        public string Title { set { this.Text = value; } }


        public void SetReasonInfo(string shortName, string fullName, string typeMainifestation, string additionally)
        {
            TB_ShortName.Text = shortName;
            TB_FullName.Text = fullName;
            CB_Type.Text = typeMainifestation;
            RTB_Additionally.Text = additionally;
        }


        private void EditingReasons_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
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
