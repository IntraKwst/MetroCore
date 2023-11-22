using IronPdf;
using System;
using System.IO;

namespace WpfApp
{
    internal class PdfCreator:IDisposable
    {
        public MemoryStream Stream { get; private set; }

        public PdfCreator(string html)
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf(html);
            Stream = pdf.Stream;
        }

        public void Dispose() => Stream?.Dispose();
    }
}
