using ServiceStation.InterfacesView;
using System;
using System.Windows.Forms;

namespace ServiceStation.Forms
{
    internal partial class EditingReasonCustomerForm : Form, IEditingReasonCustomerView
    {
        public event Action SelectionReason;
        
        public event ActionAsync Save;

        public event ActionAsync AddWork;
        public event ActionAsync EditWork;
        public event ActionAsync DeleteWork;

        public event ActionAsync AddMaterial;
        public event ActionAsync EditMaterial;
        public event ActionAsync DeleteMaterial;

        public event ActionAsync AddMaterialCustomer;
        public event ActionAsync EditMaterialCustomer;
        public event ActionAsync DeleteMaterialCustomer;
        public event ActionAsync Loading;


        public EditingReasonCustomerForm()
        {
            InitializeComponent();
            Load += EditingReasonCustomerForm_Load;

            DGV_Works.MouseDoubleClick += DGV_Works_MouseDoubleClick;
            DGV_Materials.MouseDoubleClick += DGV_Materials_MouseDoubleClick;
            DGV_MaterialsCustomer.MouseDoubleClick += DGV_MaterialsCustomer_MouseDoubleClick;
        }
        
        private async void DGV_Works_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                await EditWork?.Invoke();
        }

        private async void DGV_Materials_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                await EditMaterial?.Invoke();
        }

        private async void DGV_MaterialsCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                await EditMaterialCustomer?.Invoke();
        }

        private async void EditingReasonCustomerForm_Load(object sender, EventArgs e)
        {
            await Loading?.Invoke();
            LL_Reason.Focus();
        }

        public DataGridView Works { get { return DGV_Works; } }

        public DataGridView Materials { get { return DGV_Materials; } }

        public DataGridView MaterialsCustomer { get { return DGV_MaterialsCustomer; } }


        public string Reason { set { LL_Reason.Text = value; } }


        public string Title { set { this.Text = value; } }

        public string Sum { set { TSL_Sum.Text = value; } }

        private void TSB_Censel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void TSB_Save_Click(object sender, EventArgs e)
        {
            await Save?.Invoke();
        }

        private void LL_Reason_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectionReason?.Invoke();
        }

        private async void TSB_AddWork_Click(object sender, EventArgs e)
        {
            await AddWork?.Invoke();
        }

        private async void TSB_EditWork_Click(object sender, EventArgs e)
        {
            await EditWork?.Invoke();
        }

        private async void TSB_DeleteWork_Click(object sender, EventArgs e)
        {
            await DeleteWork?.Invoke();
        }

        private async void TSB_AddMaterial_Click(object sender, EventArgs e)
        {
            await AddMaterial?.Invoke();
        }

        private async void TSB_EditMaterial_Click(object sender, EventArgs e)
        {
            await EditMaterial?.Invoke();
        }

        private void TSB_DeleteMaterial_Click(object sender, EventArgs e)
        {
            DeleteMaterial?.Invoke();
        }

        private void TSB_AddMaterialCustomer_Click(object sender, EventArgs e)
        {
            AddMaterialCustomer?.Invoke();
        }

        private void TSB_EditMateialCustomer_Click(object sender, EventArgs e)
        {
            EditMaterialCustomer?.Invoke();
        }

        private void TSB_DeleteMaterialCustomer_Click(object sender, EventArgs e)
        {
            DeleteMaterialCustomer?.Invoke();
        }

        private void EditingReasonCustomerForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                SelectionReason?.Invoke();
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