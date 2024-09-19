﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Bridge.Problem
{
    public abstract class AdvancedRemoteControl : RemoteControl
    {
        public abstract void SetChannel(int number);
    }
}
