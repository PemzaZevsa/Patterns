using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal abstract class Client
    {
        protected readonly string name;
        protected readonly string address;
        protected readonly string number;

        public Client(string name, string address, string number)
        {
            this.name = name;
            this.address = address;
            this.number = number;
        }

        public abstract void Accept(IVisitor visitor);

    }
}
