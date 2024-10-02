using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Observer.Solution
{
    public class SpreadSheet : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Spreadsheet got notified");
        }
    }
}
