using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class Bank : Client
    {
        private readonly int branchesInsured;
        public Bank(string name, string address, string number, int branchesInsured) : base(name, address, number)
        {
            this.branchesInsured = branchesInsured;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
