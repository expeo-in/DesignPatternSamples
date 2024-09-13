using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Decorator.Problem
{
    public class CompressedAndEncryptedCloudStream: CloudStream
    {
        public override void Write(string data)
        {
            var compressed = Compress(data);
            var encrypted = Encrypt(compressed);
            base.Write(encrypted);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }

        private string Encrypt(string data)
        {
            return "!@#$%^^&&*";
        }
    }
}
