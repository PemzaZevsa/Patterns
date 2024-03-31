using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactor
{
    public class ConcreteEventHandlerA : IEventHandler
    {
        public void HandleEvent(Event e)
        {
            Console.WriteLine($"ConcreteEventHandlerA handles event of type: {e.Type}");
        }
    }
}
