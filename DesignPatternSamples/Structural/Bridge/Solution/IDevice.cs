using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Bridge.Solution
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}
