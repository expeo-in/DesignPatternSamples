using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Creational.Builder.Problem
{
    public class Slide
    {
        public string Text { get; init; }
        public Slide(string text)
        {
            Text = text;
        }
    }
}
