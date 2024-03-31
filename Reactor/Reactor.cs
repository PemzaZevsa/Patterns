using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactor
{
    public class Reactor
    {
        private Dictionary<string, IEventHandler> eventHandlers = new Dictionary<string, IEventHandler>();
        private SynchronousEventDemultiplexer demultiplexer = new SynchronousEventDemultiplexer();

        public void RegisterHandler(string eventType, IEventHandler handler)
        {
            eventHandlers[eventType] = handler;
        }

        public void RemoveHandler(string eventType)
        {
            eventHandlers.Remove(eventType);
        }

        public void HandleEvents(IEnumerable<Event> events)
        {
            foreach (var e in events)
            {
                if (eventHandlers.ContainsKey(e.Type))
                {
                    eventHandlers[e.Type].HandleEvent(e);
                }
                else
                {
                    demultiplexer.Handle(e);
                }
            }
        }
    }
}
