using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Solution
{
    internal class Webserver
    {
        private Handler handler;

        public Webserver(Handler handler)
        {
            this.handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            handler.Handle(request);
        }
    }
}
