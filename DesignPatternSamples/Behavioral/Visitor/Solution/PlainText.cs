using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatternSamples.Behavioral.Visitor.Solution
{
    internal class PlainText: IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("PlaintText heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("PlaintText anchor");
        }
    }
}