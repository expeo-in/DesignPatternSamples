using DesignPatternSamples.Behavioral.Mediator.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.SolutionUsingObserver
{
    internal class ListBox : UIControl
    {
        private string selection;

        public string Selection
        {
            get => selection;
            set
            {
                selection = value;
                NotifyEventHandlers();
            }
        }
    }
}
