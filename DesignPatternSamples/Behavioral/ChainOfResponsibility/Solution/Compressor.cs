using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Solution
{
    internal class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public void Compress(HttpRequest request)
        {
            Console.WriteLine("Compress request");
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compressing");
            return false;
        }
    }
}
