using DesignPatternSamples.Creational.Builder.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Solution
{
    public class MovieBuilder : IPresentationBuilder
    {
        Movie movie = new Movie();

        public void AddSlide(Slide slide)
        {
            movie.AddFrame(slide.Text, 10);
        }

        public Movie getMovie() { return movie; }
    }
}
