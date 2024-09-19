using DesignPatternSamples.Structural.Bridge.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Bridge.Solution
{
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();
        }
        public void TurnOff()
        {
            device.TurnOff();
        }
    }
}
