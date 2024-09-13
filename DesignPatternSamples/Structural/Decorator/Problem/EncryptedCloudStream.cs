using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Decorator.Problem
{
    public class EncryptedCloudStream: CloudStream
    {
        public override void Write(string data)
        {
            var encrypted = Encrypt(data);
            base.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "!@#$%^^&&*";
        }
    }
}
