using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Visitor.Solution
{
    internal interface IOperation
    {
        void Apply(HeadingNode node);
        void Apply(AnchorNode node);
    }
}
