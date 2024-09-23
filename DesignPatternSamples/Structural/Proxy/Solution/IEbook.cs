using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Proxy.Solution
{
    public interface IEbook
    {
        string Filename { get; init; }
        void Show();
    }
}
