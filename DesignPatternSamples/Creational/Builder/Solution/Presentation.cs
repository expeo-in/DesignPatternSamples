using DesignPatternSamples.Creational.Builder.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Solution
{
    public class Presentation
    {
        List<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }

        public void Export(IPresentationBuilder builder)
        {
            foreach (var slide in slides)
            {
                builder.AddSlide(slide);
            }
        }
    }
}
