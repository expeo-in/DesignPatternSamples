using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Flyweight.Problem
{
    public class PointService
    {

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(1, 2, PointType.CAFE, null));
            return points;
        }
    }
}
