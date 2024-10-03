using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.ChainOfResponsibility.Solution
{
    internal class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authenticating request");
            return !(request.Username == "admin" && request.Password == "admin");
        }
    }
}
