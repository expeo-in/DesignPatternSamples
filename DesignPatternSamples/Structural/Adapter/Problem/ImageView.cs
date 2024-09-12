using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Adapter.Problem
{
    public class ImageView
    {
        private readonly Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}
