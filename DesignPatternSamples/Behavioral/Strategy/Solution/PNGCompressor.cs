using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Strategy.Solution
{
    public class PNGCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing image using PNG");
        }
    }
}
