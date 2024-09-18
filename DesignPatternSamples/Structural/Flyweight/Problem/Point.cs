using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Flyweight.Problem
{
    public enum PointType
    {
        HOSPITAL,
        CAFE,
        RESTAURANT
    }
    public class Point
    {
        private readonly int x;
        private readonly int y;
        private readonly PointType pointType;
        private readonly byte[] icon;

        public Point(int x, int y, PointType pointType, byte[] icon)
        {
            this.x = x;
            this.y = y;
            this.pointType = pointType;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{pointType} at {x} {y}");
        }
    }
}
