using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Problem
{
    public class Presentation
    {
        List<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }

        public void Export(PresentationFormat presentationFormat)
        {
            if (presentationFormat == PresentationFormat.PDF)
            {
                PdfDocument pdfDocument = new PdfDocument();
                foreach (Slide slide in slides)
                {
                    pdfDocument.AddPage(slide.Text);
                }
            }
            else if (presentationFormat == PresentationFormat.Movie) 
            { 
                Movie movie = new Movie();
                foreach (Slide slide in slides)
                {
                    movie.AddFrame(slide.Text, 10);
                }
            }
        }
    }
}
