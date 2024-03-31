using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
