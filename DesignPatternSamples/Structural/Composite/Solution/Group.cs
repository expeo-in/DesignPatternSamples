using DesignPatternSamples.Creational.Prototype.Solution;
using DesignPatternSamples.Structural.Composite.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Composite.Solution
{
    public class Group: IComponent
    {
        List<IComponent> components = new List<IComponent>();

        public void Add(IComponent obj)
        {
            components.Add(obj);
        }

        public void Render()
        {
            foreach (var item in components)
            {
                item.Render();
            }
        }
    }
}
