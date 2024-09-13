using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Decorator.Problem
{
    public class CloudStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }
}
