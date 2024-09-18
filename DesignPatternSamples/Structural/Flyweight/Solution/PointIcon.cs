using DesignPatternSamples.Structural.Flyweight.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Flyweight.Solution
{
    public class PointIcon
    {
        public PointType PointType { get; init; }
        public byte[] icon {  get; init; }

        public PointIcon(PointType pointType, byte[] icon)
        {
            PointType = pointType;
            this.icon = icon;
        }
    }
}
