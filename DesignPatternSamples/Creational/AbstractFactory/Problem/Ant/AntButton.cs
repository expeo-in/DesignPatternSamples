using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.AbstractFactory.Problem.Ant
{
    public class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant Button");
        }
    }
}
