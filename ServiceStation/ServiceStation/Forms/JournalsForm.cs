using System;
using System.Drawing;
using System.Windows.Forms;
using ServiceStation.InterfacesView;

namespace ServiceStation.Forms
{
    internal partial class JournalsForm : Form, IJournalView
    {

        public Size ClientZoneSize
        {
            get
            {
                return ClientSize;
            }

            set
            {
                ClientSize = value;
            }
        }

        public DataGridView Grid
        {
            get
            {
                return DGV_Journal;
            }
        }

        public string Title
        {
            set
            {
                this.Text = value;
            }
        }

        internal JournalsForm()
        {
            InitializeComponent();
            Load += JournalsForm_Load;
            TSB_Censel.Click += (s, e) => Close();
            DGV_Journal.MouseDoubleClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    TSB_Choose_Click(s, e);
            };
            
            tstbSeach.TextChanged += TstbSeach_TextChanged;
        }

        public event Filter Seach;
        public event ActionAsync Add;
        public event ActionAsync Edit;
        public event ActionAsync Delele;
        public event ActionAsync Choose;
        public event ActionAsync Loading;

        private void TstbSeach_TextChanged(object sender, EventArgs e)
        {
            Seach?.Invoke(tstbSeach.Text);
        }

        private async void JournalsForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            DGV_Journal.Focus();
        }

        // Добавить
        private async void TSB_Add_Click(object sender, EventArgs e)
        {
            await Add?.Invoke();
        }


        // Изменить
        private async void TSB_Change_Click(object sender, EventArgs e)
        {
            await Edit?.Invoke();
        }


        // Удалить
        private async void TSB_Delete_Click(object sender, EventArgs e)
        {
            await Delele?.Invoke();
        }


        // Выбрать
        private async void TSB_Choose_Click(object sender, EventArgs e)
        {
            await Choose?.Invoke();
        }

        private void Journals_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D1 || e.Control && e.KeyCode == Keys.NumPad1)
            {
                TSB_Add.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.D2 || e.Control && e.KeyCode == Keys.NumPad2)
            {
                TSB_Change.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.D3 || e.Control && e.KeyCode == Keys.NumPad3)
            {
                TSB_Delete.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                TSB_Choose.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
