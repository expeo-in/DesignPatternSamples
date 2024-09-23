using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Proxy.Solution
{
    public class EbookProxy : IEbook
    {
        public string Filename { get; init; }
        private RealEbook ebook;

        public EbookProxy(string filename)
        {
            Filename = filename;
        }

        public void Show()
        {
            if(ebook is null)
                ebook = new RealEbook(Filename); 
            
            ebook.Show();
        }
    }
}
