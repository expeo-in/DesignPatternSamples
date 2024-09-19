using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Bridge.Problem
{
    public class SonyRemoteControl : RemoteControl
    {
        public override void TurnOff()
        {
            Console.WriteLine("Turn off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
    }
}
