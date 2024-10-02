using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.Solution
{
    internal class TextBox : UIControl
    {
        private string content;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string Content
        {
            get => content;
            set
            {
                content = value;
                owner.Changed(this);
            }
        }
    }
}
