using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Problem
{
    internal class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            Console.WriteLine("Authenticating request");
            return request.Username == "admin" && request.Password == "admin";
        }
    }
}
