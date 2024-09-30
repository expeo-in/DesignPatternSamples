using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatternSamples.Behavioral.Command.Solution
{
    public class Button
    {
        private readonly ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }
    }
}