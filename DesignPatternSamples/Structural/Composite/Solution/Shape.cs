using DesignPatternSamples.Structural.Composite.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Composite.Solution
{
    public class Shape: IComponent
    {
        public void Render()
        {
            Console.WriteLine("Rendering Shape");
        }
    }
}
