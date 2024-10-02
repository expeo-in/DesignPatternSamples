using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.Solution
{
    internal class Button : UIControl
    {
        bool isEnabled;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled { 
            get => isEnabled;
            set { 
                isEnabled = value;
                owner.Changed(this);
            }
        }
    }
}
