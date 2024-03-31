using System;
using System.Collections.Generic;

namespace Reactor
{

    public class Event
    {
        public string Type { get; private set; }

        public Event(string type)
        {
            Type = type;
        }
    }

    public interface IEventHandler
    {
        void HandleEvent(Event e);
    }

    public class ConcreteEventHandlerA : IEventHandler
    {
        public void HandleEvent(Event e)
        {
            Console.WriteLine($"ConcreteEventHandlerA handles event of type: {e.Type}");
        }
    }

    public class ConcreteEventHandlerB : IEventHandler
    {
        public void HandleEvent(Event e)
        {
            Console.WriteLine($"ConcreteEventHandlerB handles event of type: {e.Type}");
        }
    }

    public class SynchronousEventDemultiplexer
    {
        public void Handle(Event e)
        {
            // logic
            Console.WriteLine($"Demultiplexer handles event of type: {e.Type}");
        }
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            Reactor reactor = new Reactor();

            reactor.RegisterHandler("EventA", new ConcreteEventHandlerA());
            reactor.RegisterHandler("EventB", new ConcreteEventHandlerB());

            var events = new List<Event>
            {
                new Event("EventA"),
                new Event("EventB"),
                new Event("EventC")
            };

            reactor.HandleEvents(events);
        }
    }

}
