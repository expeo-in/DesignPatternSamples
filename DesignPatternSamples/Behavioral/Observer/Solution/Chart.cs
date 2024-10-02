using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Observer.Solution
{
    public class Chart: IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Chart got notified");
        }
    }
}
