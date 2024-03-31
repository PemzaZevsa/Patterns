using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class Resident : Client
    {
        private readonly string insurenceClass;
        public Resident(string name, string address, string number, string insurenceClass) : base(name, address, number)
        {
            this.insurenceClass = insurenceClass;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
