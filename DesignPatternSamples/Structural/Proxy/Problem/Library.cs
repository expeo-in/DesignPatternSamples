using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Proxy.Problem
{
    public class Library
    {
        Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();

        public void AddEbook(Ebook ebook)
        {
            ebooks.Add(ebook.Filename, ebook);
        }

        public void OpenEbook(string filename)
        {
            ebooks[filename].Show();
        }
    }
}
