using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Prototype.Solution
{
    public interface IComponent
    {
        void Render();
        IComponent Clone();
    }
}
