using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Adsisplus.Cotyrsa.Shared.Utilities.Formats
{
    public class WordWriter : IDisposable
    {
        //private readonly string WordLocalPath = @"C:\Temp\PlantillasWord\Documento.docx";
        private readonly string WordLocalPath;

        private readonly Word.Document Document;
        private readonly Word.Application WordApp;
        private bool disposedValue;

        public WordWriter(string wordDocumentTemplate)
        {
            WordApp = new Word.Application
            {
                //Visible = true
            };
            WordLocalPath = wordDocumentTemplate;
            Document = WordApp.Documents.Add(WordLocalPath);
        }


        public void ReplaceGenericData(IEnumerable<KeyValuePair<string, string>> keysToWrite)
        {
            ReplaceTextInDocument(keysToWrite);
        }



        public void CreateTableByTag(List<string[]> tableData, string tag)
        {
            int cols = 5;
            var contentTablaMateriales = Document.SelectContentControlsByTag(tag);
            Word.Range firstRange = contentTablaMateriales[1].Range;
            Word.Table table = Document.Tables.Add(firstRange, tableData.Count, cols);
            float padding = 3;
            for (int iRow = 1; iRow <= tableData.Count; iRow++)
            {
                for (int iCol = 1; iCol <= cols; iCol++)
                {
                    Word.Cell cell = table.Cell(iRow, iCol);
                    if (iRow == 1)
                    {
                        cell.Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray125;
                        cell.Range.Bold = 3;
                    }
                    if (iCol != cols)
                    {
                        cell.Width =  50f;
                        cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else
                    {
                        cell.Width = 300f;
                        cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    }
                    
                    cell.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleOutset;
                    cell.TopPadding = padding;
                    cell.LeftPadding = padding;
                    cell.RightPadding = padding;
                    cell.BottomPadding = padding;
                    string cellValue = tableData[iRow - 1][iCol - 1];
                    cell.Range.Text = cellValue;
                }
            }

        }

        public void SaveAndClose(string outputPath)
        {
            string pdfOutputFormatPath = $"{outputPath.Replace("docx","pdf")}";
            Document.SaveAs2(outputPath);
            Document.ExportAsFixedFormat(pdfOutputFormatPath, Word.WdExportFormat.wdExportFormatPDF, false, Word.WdExportOptimizeFor.wdExportOptimizeForOnScreen);
            Document.Close(false);
            Marshal.ReleaseComObject(Document);
        }

        private void ReplaceTextInDocument(IEnumerable<KeyValuePair<string, string>> elementsToWrite)
        {
            WriteTags(elementsToWrite);
            WriteMatchs(elementsToWrite);
        }

        private void WriteTags(IEnumerable<KeyValuePair<string, string>> elementsToWrite)
        {
            foreach (var tagElement in elementsToWrite)
            {
                var tagContentControls = Document.SelectContentControlsByTag(tagElement.Key);
                if (tagContentControls.Count > 0)
                {
                    ReplaIfExists(tagContentControls[1], tagElement);
                    continue;
                }
                //Console.WriteLine($"No se encontró {tagElement.Key}");
            }
        }

        private void WriteMatchs(IEnumerable<KeyValuePair<string, string>> elementsToWrite)
        {
            foreach (var tagElement in elementsToWrite)
            {
                foreach (Word.Section section in Document.Sections)
                {
                    ReplaceIfExists(section.Range, tagElement);
                    if (section.Headers.Count > 0)
                    {
                        ReplaceIfExists(section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range, tagElement);
                    }
                }
            }
        }

        private void ReplaIfExists(Word.ContentControl contentControl, KeyValuePair<string, string> newText)
        => ReplaceIfExists(contentControl.Range, newText);


        private void ReplaceIfExists(Word.Range range, KeyValuePair<string, string> toWrite)
        {
            object o = Missing.Value;
            object oFalse = false;
            //object oTrue = true;
            Word.Find find = range.Find;
            object findText = toWrite.Key;
            //  object findText = { "[Todays date]","[]" };
            object replacText = toWrite.Value;   //gets todays date and time to doc
            object replace = Word.WdReplace.wdReplaceAll;
            object findWrap = Word.WdFindWrap.wdFindContinue;
            find.Execute(ref findText, ref o, ref o, ref o, ref oFalse, ref o,
                ref o, ref findWrap, ref o, ref replacText,
                ref replace, ref o, ref o, ref o, ref o);

            //Marshal.FinalReleaseComObject(find);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                    WordApp.Quit();
                    Marshal.ReleaseComObject(WordApp);
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                //WordLocalPath = null;
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~WordWriter()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
