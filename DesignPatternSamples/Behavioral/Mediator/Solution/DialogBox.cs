using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.Solution
{
    internal abstract class DialogBox
    {
       public abstract void Changed(UIControl control);
    }
}
