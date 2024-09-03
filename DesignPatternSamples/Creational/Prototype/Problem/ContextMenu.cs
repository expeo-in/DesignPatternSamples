using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Prototype.Problem
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            if (component is Circle)
            {
                Circle source = (Circle)component;
                Circle target = new Circle();
                target.Radius = source.Radius;
                //Add target to document
            }
        }
    }
}
