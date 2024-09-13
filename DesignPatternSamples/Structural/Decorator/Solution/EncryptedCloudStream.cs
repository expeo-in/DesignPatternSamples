using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Decorator.Solution
{
    public class EncryptedCloudStream: IStream
    {
        private IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            _stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "!@#$%^^&&*";
        }
    }
}
