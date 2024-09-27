using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Strategy.Solution
{
    public interface IFilter
    {
        void Apply(string fileName);
    }
}
