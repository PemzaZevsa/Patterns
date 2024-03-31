using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class Company : Client
    {
        private readonly int nbrOfEmployees;
        public Company(string name, string address, string number, int nbrOfEmployees) : base(name, address, number)
        {
            this.nbrOfEmployees = nbrOfEmployees;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
