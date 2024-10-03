using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Problem
{
    internal class Webserver
    {
        public void Handle()
        {
            //Authenticate
            var authenticator = new Authenticator();
            authenticator.Authenticate(new HttpRequest { Username = "admin", Password = "admin" });

            //Log

            //Compress 
        }
    }
}
