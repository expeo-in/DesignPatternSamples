using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Visitor.Problem
{
    internal class HeadingNode: IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlight heading");
        }
    }
}
