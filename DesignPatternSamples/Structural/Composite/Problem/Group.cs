using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Composite.Problem
{
    public class Group
    {
        List<Object> objects = new List<object>();

        public void Add(Object obj)
        {
            objects.Add(obj);
        }

        public void Render()
        {
            foreach (var item in objects)
            {
                if (item is Shape)
                {
                    ((Shape)item).Render();
                }
                else
                {
                    ((Group)item).Render();
                }
            }
        }
    }
}
