﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Iterator.Solution
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();

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

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }


        public class ListIterator : IIterator
        {
            private readonly BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }
            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return index < history.urls.Count;
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
