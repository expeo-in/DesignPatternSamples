using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Proxy.Solution
{
    public class Library
    {
        Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>();

        public void AddEbook(IEbook ebook)
        {
            ebooks.Add(ebook.Filename, ebook);
        }

        public void OpenEbook(string filename)
        {
            ebooks[filename].Show();
        }
    }
}
