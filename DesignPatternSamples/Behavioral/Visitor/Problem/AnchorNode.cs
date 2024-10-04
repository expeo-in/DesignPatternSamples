using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Visitor.Problem
{
    internal class AnchorNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlight anchor");
        }
    }
}
