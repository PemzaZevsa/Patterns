using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactor
{
    public class ConcreteEventHandlerB : IEventHandler
    {
        public void HandleEvent(Event e)
        {
            Console.WriteLine($"ConcreteEventHandlerB handles event of type: {e.Type}");
        }
    }
}
