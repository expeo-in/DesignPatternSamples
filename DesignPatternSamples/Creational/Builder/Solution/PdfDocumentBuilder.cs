using DesignPatternSamples.Creational.Builder.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Solution
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        PdfDocument pdfDocument = new PdfDocument();

        public void AddSlide(Slide slide)
        {
            pdfDocument.AddPage(slide.Text);
        }

        public PdfDocument GetPdfDocument() => pdfDocument;
    }
}
