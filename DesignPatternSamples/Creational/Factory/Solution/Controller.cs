using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Factory.Solution
{
    public class Controller
    {
        public void Render(string viewName, Dictionary<string, object> context)
        {
            var viewEngine = CreateViewEngine();
            var html = viewEngine.Render(viewName, context);
            Console.WriteLine(html);
        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
