using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Solution
{
    internal class Logger: Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging request");
            return false;
        }
    }
}
