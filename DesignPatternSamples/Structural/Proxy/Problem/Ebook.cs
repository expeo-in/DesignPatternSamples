using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Proxy.Problem
{
    public class Ebook
    {
        public string Filename { get; init; }

        public Ebook(string filename)
        {
            Filename = filename;
            Load();
        }

        public void Load()
        {
            Console.WriteLine("Loading ebook " + Filename);
        }

        public void Show()
        {
            Console.WriteLine("Showing ebook " + Filename);
        }
    }
}
