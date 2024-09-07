using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Factory.Problem
{
    public class Controller
    {
        public void Render(string viewName, Dictionary<string, object> context, IViewEngine viewEngine)
        {
            var html = viewEngine.Render(viewName, context);
            Console.WriteLine(html);
        }
    }
}
