using DesignPatternSamples.Structural.Facade.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Structural.Facade.Solution
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("AppId", "key");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}
