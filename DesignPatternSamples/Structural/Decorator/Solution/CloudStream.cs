using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Decorator.Solution
{
    public class CloudStream: IStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }
}
