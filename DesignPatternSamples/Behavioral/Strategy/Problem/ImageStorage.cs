using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Strategy.Problem
{
    public class ImageStorage
    {
        private string compressor;
        private string filter;

        public ImageStorage(string compressor, string filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void Store()
        {
            if(compressor == "JPG")
                Console.WriteLine("Compressing image using JPG");
            else if(compressor == "PNG")
                Console.WriteLine("Compressing image using PNG");

            if (filter == "BW")
                Console.WriteLine("Apply filter BW");
            else if (filter == "HC")
                Console.WriteLine("Apply high contrast");
        }
    }
}
