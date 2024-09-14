using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Facade.Problem
{
    public class Message
    {
        private readonly string content;

        public Message(string content)
        {
            this.content = content;
        }
    }
}
