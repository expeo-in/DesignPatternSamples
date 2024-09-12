using DesignPatternSamples.Structural.Adapter.Problem;
using DesignPatternSamples.Structural.Adapter.Problem.AvaFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Adapter.Solution
{
    public class CaramelFilter : IFilter
    {
        private Caramel caramel;
        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }
        public void Apply(Image image)
        {
            caramel.Init();
            caramel.Render(image);
        }
    }
}
