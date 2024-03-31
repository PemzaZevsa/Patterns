using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class InsuranceMessagingVisitor : IVisitor
    {
        public void SendInsuranceMails(List<Client> clients)
        {
            foreach (Client client in clients) 
            { 
                client.Accept(this); 
            }
        }
        public void Visit(Bank bank)
        {
            Console.WriteLine("Sending mail to bank");
        }

        public void Visit(Company company)
        {
            Console.WriteLine("Sending mail to company");
        }

        public void Visit(Resident resident)
        {
            Console.WriteLine("Sending mail to resident");
        }
    }
}
