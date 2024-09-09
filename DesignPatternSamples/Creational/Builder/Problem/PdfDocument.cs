using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Problem
{
    public class PdfDocument
    {
        public void AddPage(string text)
        {
            Console.WriteLine("Adding a page to pdf");
        }
    }
}
