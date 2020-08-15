using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using ServiceStation.PrintDocument;

namespace ServiceStation.Forms
{
    internal partial class PrintForm : Form
    {
        private DocumentViewer _document;

        internal Document Document { get; set; }


        internal PrintForm()
        {
            InitializeComponent();

            lblWaiting.Anchor = AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top;

            _document = new DocumentViewer();

            EH_DocumentViewer.Child = _document;

            Load += PrintForm_Load;

            FormClosed += PrintForm_FormClosed;
        }

        private async void PrintForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Document.Load());
            
            _document.Document = Document.DocumentOutput();

            lblWaiting.Visible = false;

            _document.Focus();
        }

        private void PrintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\FilePrint.xps");
            }
            catch (Exception) { }
        }
    }
}