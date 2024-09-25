using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.State.Problem
{
    public enum ToolType
    {
        SELECTION,
        BRUSH,
        ERASER
    }
    public class Canvas
    {
        public ToolType CurrentTool {  get; set; }

        public void MouseDown()
        {
            if (CurrentTool == ToolType.SELECTION)
                Console.WriteLine("Selection Icon");
            else if (CurrentTool == ToolType.BRUSH)
                Console.WriteLine("Brush Icon");
            else if (CurrentTool == ToolType.ERASER)
                Console.WriteLine("Eraser Icon");
        }

        public void MouseUp()
        {
            if (CurrentTool == ToolType.SELECTION)
                Console.WriteLine("Draw dashed rectangle");
            else if (CurrentTool == ToolType.BRUSH)
                Console.WriteLine("Draw a line");
            else if (CurrentTool == ToolType.ERASER)
                Console.WriteLine("Eraser something");
        }
    }
}
