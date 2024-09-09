using DesignPatternSamples.Creational.Builder.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Solution
{
    public interface IPresentationBuilder
    {
        void AddSlide(Slide slide);
    }
}
