using System;
using System.Windows.Forms;
using ServiceStation.InterfacesView;

namespace ServiceStation.Forms
{
    internal partial class EditingPostForm : Form, IEditingPostView
    {

        public event ActionAsync Save;
        public event ActionAsync Loading;

        internal EditingPostForm()
        {
            InitializeComponent();
            Load += EditingPostForm_Load;
            TSB_Censel.Click += (s, e) => Close();
            TSP_Save.Click += async (s, e) => await Save?.Invoke();
        }

        private async void EditingPostForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            TB_Post.Focus();
            TB_Post.SelectionStart = TB_Post.TextLength;
        }

        public string Post { get { return TB_Post.Text; } set { TB_Post.Text = value; } }

        public string Title { set { this.Text = value; } }

        private void EditingPost_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    TSP_Save.PerformClick();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
