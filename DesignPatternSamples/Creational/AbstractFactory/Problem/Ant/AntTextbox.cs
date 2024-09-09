using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.AbstractFactory.Problem.Ant
{
    public class AntTextbox: ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Ant Textbox");
        }
    }
}
