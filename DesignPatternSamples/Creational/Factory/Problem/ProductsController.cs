using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Factory.Problem
{
    public class ProductsController: Controller
    {
        public void ListProducts()
        {
            Dictionary<string, object> context = new Dictionary<string, object>();
            Render("products.html", context, new MatchaViewEngine());
        }
    }
}
