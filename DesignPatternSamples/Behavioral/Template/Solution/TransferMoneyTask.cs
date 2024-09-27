﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Template.Solution
{
    public class TransferMoneyTask: Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
        }
    }
}
