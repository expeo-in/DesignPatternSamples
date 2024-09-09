using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Problem
{
    public class Movie
    {
        public void AddFrame(string text, int duration)
        {
            Console.WriteLine("Adding a frame to movie");
        }
    }
}
