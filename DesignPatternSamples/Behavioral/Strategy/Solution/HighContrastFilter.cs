using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Strategy.Solution
{
    public class HighContrastFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying High Contrast filter");
        }
    }
}
