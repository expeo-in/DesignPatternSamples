using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Bridge.Solution
{
    public class SamsungTV: IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("SamsungTV Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("SamsungTV Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("SamsungTV Turn On");
        }
    }
}
