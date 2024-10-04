using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Visitor.Solution
{
    internal class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Highlight heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Highlight anchor");
        }
    }
}
