using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.State.Solution
{
    public class BrushTool: ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
