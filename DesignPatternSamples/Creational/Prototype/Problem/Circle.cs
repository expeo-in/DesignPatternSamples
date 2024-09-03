using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Prototype.Problem
{
    public class Circle : IComponent
    {
        public int Radius { get; set; }

        public void Render()
        {
            Console.WriteLine("Rendering a Circle");
        }
    }
}
