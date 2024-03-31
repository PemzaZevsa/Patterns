namespace FrontControllerPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();
            Client client = new Client(handler);

            client.SendRequest("GET");
            client.SendRequest("POST");
            client.SendRequest("DELETE");
        }
    }
    class Handler
    {
        public void HandleRequest(string request)
        {
            if (request == "GET")
            {
                new GetCommand().Execute();
            }
            else if (request == "POST")
            {
                new PostCommand().Execute();
            }
            else
            {
                Console.WriteLine("Неверный тип запроса");
            }
        }
    }

    // Абстрактная команда
    interface ICommand
    {
        void Execute();
    }

    // Конкретная команда для GET запроса
    class GetCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение GET запроса");
        }
    }

    // Конкретная команда для POST запроса
    class PostCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение POST запроса");
        }
    }

    // Клиент
    class Client
    {
        private Handler handler;

        public Client(Handler handler)
        {
            this.handler = handler;
        }

        public void SendRequest(string request)
        {
            handler.HandleRequest(request);
        }
    }
}
