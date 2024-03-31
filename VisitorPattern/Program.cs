namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resident resident = new Resident("", "", "", "");
            Company company = new Company("", "", "",20);
            Bank bank = new Bank("", "", "", 3);

            List<Client> clients = new List<Client>();
            clients.Add(resident);
            clients.Add(company);
            clients.Add(bank);
            
            InsuranceMessagingVisitor messaging = new InsuranceMessagingVisitor();
            messaging.SendInsuranceMails(clients);

            //Console.ReadLine();
        }
    }
}
