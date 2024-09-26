using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Iterator.Solution
{
    public interface IIterator
    {
        bool HasNext();
        string Current();
        void Next();
    }
}
