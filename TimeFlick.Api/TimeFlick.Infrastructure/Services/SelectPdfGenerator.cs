using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Interfaces;

namespace TimeFlick.Infrastructure.Services
{
    public class SelectPdfGenerator : IPdfGenerator
    {
        public byte[] GeneratePdfFromHtml(string htmlContent)
        {
            var converter = new HtmlToPdf();
            // Set the page size and orientation
            converter.Options.PdfPageSize = PdfPageSize.Legal;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
            // Optionally adjust margins
            converter.Options.MarginTop = 10;
            converter.Options.MarginBottom = 10;
            converter.Options.MarginLeft = 10;
            converter.Options.MarginRight = 10;

            var doc = converter.ConvertHtmlString(htmlContent);
            var pdf = doc.Save();
            doc.Close();
            return pdf;
        }
    }
}
