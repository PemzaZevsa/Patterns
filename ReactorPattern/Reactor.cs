using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorPattern
{
    internal class Reactor
    {
        public List<IEventHandler> Events = new List<IEventHandler>();
        public void HandleEvents()
        {
            while(Events.Count > 0)
            {

            }
        }
        public void RegisterHandler(IEventHandler eventHandler)
        {
            Events.Add(eventHandler);
        }
        public void RemoveHandler()
        {

        }

    }
}
