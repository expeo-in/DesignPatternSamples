using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Problem
{
    internal class Logger
    {
        public void Log(HttpRequest request)
        {
            Console.WriteLine("Logging request");
        }
    }
}
