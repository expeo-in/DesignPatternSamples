using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Prototype.Solution
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            IComponent newComponent = component.Clone();
            //Add target to document
        }
    }
}
