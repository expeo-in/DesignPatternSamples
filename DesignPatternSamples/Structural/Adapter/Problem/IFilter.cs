using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Adapter.Problem
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}
