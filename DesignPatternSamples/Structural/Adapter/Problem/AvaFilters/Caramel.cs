using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Adapter.Problem.AvaFilters
{
    public class Caramel
    {
        public void Init() { }

        public void Render(Image image)
        {
            Console.WriteLine("Applying caramel filter");
        }
    }
}
