using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Visitor.Solution
{
    internal class HtmlDocument
    {
        List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void Apply(IOperation operation)
        {
            foreach (IHtmlNode node in nodes)
            {
                node.Apply(operation);
            }
        }
    }
}
