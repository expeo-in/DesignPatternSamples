using DesignPatternSamples.Structural.Flyweight.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Flyweight.Solution
{
    public class PointService
    {
        private readonly PointIconFactory pointIconFactory;

        public PointService(PointIconFactory pointIconFactory)
        {
            this.pointIconFactory = pointIconFactory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(1, 2, pointIconFactory.GetPointIcon(PointType.CAFE)));
            return points;
        }
    }
}
