using System;
using System.Collections.Generic;

namespace Reactor
{
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
