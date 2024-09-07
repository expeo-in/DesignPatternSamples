using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Factory.Solution
{
    public class SharpController: Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
