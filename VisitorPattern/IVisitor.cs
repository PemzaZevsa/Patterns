using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal interface IVisitor
    {
        void Visit(Bank bank);
        void Visit(Company company);
        void Visit(Resident resident);
    }
}
