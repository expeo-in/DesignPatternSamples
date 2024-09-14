using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Facade.Problem
{
    public class NotificationServer
    {
        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appID, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken token, Message message, string target) 
        {
            Console.WriteLine("Sending a message");
        }
    }
}
