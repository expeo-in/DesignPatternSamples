using DesignPatternSamples.Structural.Bridge.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Bridge.Solution
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }
    }
}
