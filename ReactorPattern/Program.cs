namespace ReactorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reactor reactor = new Reactor();

            reactor.HandleEvents();

            Console.WriteLine("Hello, World!");
        }
    }
}
