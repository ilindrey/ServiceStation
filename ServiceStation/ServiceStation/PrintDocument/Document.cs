using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;
using Word = Microsoft.Office.Interop.Word;

namespace ServiceStation.PrintDocument
{
    internal abstract class Document: Message, IDisposable
    {
        protected string directory = string.Empty;

        protected Word.Application WordAplication { get; set; }
        protected Word.Document WordDocument { get; set; }

        protected int NumberApplication { get; set; }
        protected string DirectoriFileSave { get { return string.Format(Directory.GetCurrentDirectory() + @"\FilePrint.xps"); } }

        protected Document(int numberApplication, string directory)
        {
            NumberApplication = numberApplication;
            this.directory = directory;
        }

        protected void SetFontRow(Word.Row row)
        {
            row.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            row.Range.Font.Bold = 0;
            row.Range.Font.Italic = 0;
            row.Range.Font.Name = "Times New Roman";
        }

        protected void SetParameterNomenclatureRow(Word.Table table)
        {
            var row = table.Rows[table.Rows.Count];

            row.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            row.Range.Font.Bold = 0;
            row.Range.Font.Italic = 0;
            row.Range.Font.Name = "Times New Roman";

            int rowCount = table.Rows.Count;

            SetFontCell(table.Rows[2].Cells[2], Word.WdParagraphAlignment.wdAlignParagraphRight, 0);
            SetFontCell(table.Rows[2].Cells[3], Word.WdParagraphAlignment.wdAlignParagraphRight, 0);
            SetFontCell(table.Rows[2].Cells[4], Word.WdParagraphAlignment.wdAlignParagraphRight, 0);
            SetFontCell(table.Rows[2].Cells[5], Word.WdParagraphAlignment.wdAlignParagraphRight, 0);
        }

        protected void SetFontCell(Word.Cell cell, Word.WdParagraphAlignment aligment, int bold)
        {
            cell.Range.ParagraphFormat.Alignment = aligment;
            cell.Range.Font.Bold = bold;
            cell.Range.Font.Name = "Times New Roman";
        }

        protected void MergeTotalRow(Word.Table table, string totalText, decimal amount, decimal total)
        {
            table.Rows.Add();

            int rowCount = table.Rows.Count;

            object begCell = table.Cell(rowCount, 3).Range.Start;
            object endCell = table.Cell(rowCount, 5).Range.End;

            WordDocument.Range(ref begCell, ref endCell).Cells.Merge();

            table.Rows[rowCount].Cells[1].Range.Font.Bold = 1;
            table.Rows[rowCount].Cells[1].Range.Text = totalText;

            if(rowCount == 2)
            {
                table.Rows[rowCount].Cells[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                table.Rows[rowCount].Cells[2].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                table.Rows[rowCount].Cells[3].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                table.Rows[rowCount].Cells[2].Range.Font.Bold = 0;
                table.Rows[rowCount].Cells[3].Range.Font.Bold = 0;
            }

            table.Rows[rowCount].Cells[2].Range.Text = amount.ToString("0");
            table.Rows[rowCount].Cells[3].Range.Text = total.ToString("0.00");
        }

        protected void ReplaceWordStub(string stubToReplace, string text)
        {
            var range = WordDocument.Content;

            if (string.IsNullOrEmpty(text))
                text = string.Empty;

            int startIndex = 0;
            int count = 250;
            string parametr = "{str}";
            string insertText = string.Empty;
            bool verificationText = false;
            bool start = true;


            while (true)
            {

                while (count > text.Length - startIndex)
                {
                    count--;
                    verificationText = true;
                }

                if (!verificationText)
                    insertText = text.Substring(startIndex, count) + parametr;
                else
                    insertText = text.Substring(startIndex, count);


                range.Find.ClearFormatting();


                if (start)
                {
                    range.Find.Execute(FindText: stubToReplace, ReplaceWith: insertText);
                    start = false;
                }
                else
                {
                    range.Find.Execute(FindText: parametr, ReplaceWith: insertText);
                }

                if (verificationText)
                    break;

                startIndex += 250;
            }
        }

        protected string GetDateString(DateTime? date)
        {
            if (date == null)
                return null;
            return ((DateTime)date).ToString("dd MMMM yyyy");
        }

        internal Word.Document WordOpen(string documentName)
        {
            Word.Document document = null;
            //try
            //{
            ZipArchive archie = ZipFile.OpenRead("template.dat");
            //string currentTemplate = directory.Substring(directory.LastIndexOf('\\')+1);
            ZipArchiveEntry entry = archie.GetEntry(directory.Substring(directory.LastIndexOf('\\')+1));
            //entry.Open();
            //string surrentDirectory = Directory.GetCurrentDirectory();
            string currentTemplate = Directory.GetCurrentDirectory() + @"\DocumentTemplate";

            entry.ExtractToFile(currentTemplate, true);

            WordAplication = new Word.Application();
            document = WordAplication.Documents.Open(currentTemplate, Visible: false);
            //}
            //catch (Exception ex)
            //{
            //    ShowError(ex.Message);
            //}
            //finally { }
            return document;
        }

        protected void Save()
        {
            WordDocument.SaveAs2(DirectoriFileSave, FileFormat: Word.WdSaveFormat.wdFormatXPS);

            Dispose();
        }

        internal IDocumentPaginatorSource DocumentOutput()
        {
            IDocumentPaginatorSource source = null;

            try
            {
                using (XpsDocument xpsDocument = new XpsDocument(DirectoriFileSave, FileAccess.Read))
                {
                    source = xpsDocument?.GetFixedDocumentSequence();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return source;
        }


        internal abstract void Load();

        public void Dispose()
        {
            //WordDocument?.Close();
            WordAplication?.Quit(false);

            WordDocument = null;
            WordAplication = null;

            try
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\DocumentTemplate");
            }
            catch (Exception) { }
        }
    }
}
