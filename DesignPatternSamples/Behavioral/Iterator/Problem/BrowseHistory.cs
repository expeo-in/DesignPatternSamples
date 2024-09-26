using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Iterator.Problem
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();

        public List<string> Urls { get => urls; }

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop() 
        { 
            var lastIndex = urls.Count - 1;
            var lastUrl = urls[lastIndex];
            urls.RemoveAt(lastIndex);
            return lastUrl;
        }

    }
}
