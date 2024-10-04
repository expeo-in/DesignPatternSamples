using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Visitor.Solution
{
    internal class AnchorNode : IHtmlNode
    {
        public void Apply(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
