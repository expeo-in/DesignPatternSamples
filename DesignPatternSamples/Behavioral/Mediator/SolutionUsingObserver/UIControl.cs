using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.SolutionUsingObserver
{
    internal abstract class UIControl
    {
        List<Action> eventHandlers = new List<Action>();

        public void AddEventHandler(Action eventHandler)
        {
            eventHandlers.Add(eventHandler);
        }

        protected void NotifyEventHandlers()
        {
            foreach (Action handler in eventHandlers)
            {
                handler.Invoke();
            }
        }
    }
}
