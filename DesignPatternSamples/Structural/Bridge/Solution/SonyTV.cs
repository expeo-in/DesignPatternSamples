using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Bridge.Solution
{
    public class SonyTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("SonyTV Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("SonyTV Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("SonyTV Turn On");
        }
    }
}
