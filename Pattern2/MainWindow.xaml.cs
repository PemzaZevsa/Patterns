using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pattern2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Handler handler;
        Client client;
        public MainWindow()
        {
            InitializeComponent();
            handler = new Handler();
            client = new Client(handler);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client.SendRequest("GET");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            client.SendRequest("POST");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
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