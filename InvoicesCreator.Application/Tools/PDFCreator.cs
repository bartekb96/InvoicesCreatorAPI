using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain.Models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Tools
{
    public class PDFCreator : IPDFCreator
    {
        public async Task<bool> CreateInvoicePDF(Invoice invoice)
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                PdfDocument document = new PdfDocument();

                PdfPage page = document.AddPage();

                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Arial", 20);
                XFont plainFont = new XFont("Arial", 12);

                XImage logo = XImage.FromFile("C:\\Users\\Bartek\\Desktop\\wazne rzeczy\\FakturyNL\\logo\\logo.png");
                gfx.DrawImage(logo, 10, 10, 60, 100);

                gfx.DrawString($"Faktura numer: {invoice.InvoiceNumber}", titleFont, XBrushes.Black,
                    new XRect(100, 30, page.Width - 100, 100), XStringFormats.CenterRight);

                gfx.DrawString($"Faktura numer: {invoice.InvoiceNumber}", titleFont, XBrushes.Black,
                    new XRect(100, 30, page.Width - 100, 100), XStringFormats.CenterRight);



                string filemane = invoice.InvoiceNumber.Replace(@"\", "_");
                filemane = filemane.Replace(@"/", "_");

                document.Save($"C:\\Users\\Bartek\\Desktop\\wazne rzeczy\\FakturyNL\\{filemane}.pdf");

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
