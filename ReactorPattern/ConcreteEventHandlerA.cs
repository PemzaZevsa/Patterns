using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReactorPattern
{
    internal class ConcreteEventHandlerA : IEventHandler
    {
        private readonly string name;

        public ConcreteEventHandlerA(string name)
        {
            this.name = name;
        }
        public void GetHandle()
        {
            throw new NotImplementedException();
        }

        public void HandleEvent()
        {
            Console.WriteLine($"Event handled by {name}");
        }
    }
}
