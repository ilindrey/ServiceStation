using System;
using System.Windows.Forms;
using ServiceStation.InterfacesView;

namespace ServiceStation.Forms
{
    internal partial class EditingModelForm : Form, IEditingModelView
    {
        public event ActionAsync Save;
        public event ActionAsync Loading;


        public event Action SelectionMark;


        internal EditingModelForm()
        {
            InitializeComponent();

            Load += EditingModelForm_Load;

            TSB_Censel.Click += TSB_Censel_Click; ;

            TSB_Save.Click += TSB_Save_Click;

            LL_Mark.Click += LL_Mark_Click;
        }


        private async void EditingModelForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_Name.Focus();
            TB_Name.SelectionStart = TB_Name.TextLength;
        }
        
        private void TSB_Censel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void LL_Mark_Click(object sender, EventArgs e)
        {
            SelectionMark?.Invoke();
        }

        public string NameMark
        {
            get { return LL_Mark.Text; }
            set { LL_Mark.Text = value; }
        }

        public string Title
        {
            set { this.Text = value; }
        }

        public string NameModel { get { return TB_Name.Text; } }

        public void SetModelInfo(string nameMark, string name)
        {
            LL_Mark.Text = nameMark;
            TB_Name.Text = name;
        }

        private void EditingModelForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Enter)
            {
                SelectionMark?.Invoke();
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
