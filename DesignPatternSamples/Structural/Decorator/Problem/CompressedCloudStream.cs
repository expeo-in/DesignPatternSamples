using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Decorator.Problem
{
    public class CompressedCloudStream: CloudStream
    {
        public override void Write(string data)
        {
            var compressed = Compress(data);
            base.Write(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
