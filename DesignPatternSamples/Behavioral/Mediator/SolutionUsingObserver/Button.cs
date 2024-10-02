using DesignPatternSamples.Behavioral.Mediator.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.SolutionUsingObserver
{
    internal class Button : UIControl
    {
        bool isEnabled;

        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                isEnabled = value;
                NotifyEventHandlers();
            }
        }
    }
}
