using DesignPatternSamples.Structural.Flyweight.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Flyweight.Solution
{
    public class PointIconFactory
    {
        Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType pointType)
        {
            if(!icons.ContainsKey(pointType))
                icons.Add(pointType, new PointIcon(pointType, null));

            return icons[pointType];
        }
    }
}
