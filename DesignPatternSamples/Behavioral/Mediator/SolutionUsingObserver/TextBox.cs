using DesignPatternSamples.Behavioral.Mediator.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.SolutionUsingObserver
{
    internal class TextBox : UIControl
    {
        private string content;

        public string Content
        {
            get => content;
            set
            {
                content = value;
                NotifyEventHandlers();
            }
        }
    }
}
