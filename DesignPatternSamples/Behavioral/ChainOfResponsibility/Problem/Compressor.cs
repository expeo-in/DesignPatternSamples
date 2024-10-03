using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Problem
{
    internal class Compressor
    {
        public void Compress(HttpRequest request)
        {
            Console.WriteLine("Compress request");
        }
    }
}
