﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Visitor.Problem
{
    internal class HtmlDocument
    {
        List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void Highlight()
        {
            foreach (IHtmlNode node in nodes)
            {
                node.Highlight();
            }
        }
    }
}
