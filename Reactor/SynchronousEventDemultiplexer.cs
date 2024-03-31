using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactor
{
    public class SynchronousEventDemultiplexer
    {
        public void Handle(Event e)
        {
            // logic
            Console.WriteLine($"Demultiplexer handles event of type: {e.Type}");
        }
    }
}
