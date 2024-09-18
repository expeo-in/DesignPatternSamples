using DesignPatternSamples.Structural.Flyweight.Problem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Flyweight.Solution
{
    public class Point
    {
        private readonly int x;
        private readonly int y;
        private readonly PointIcon icon;

        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{icon.PointType} at {x} {y}");
        }
    }
}
