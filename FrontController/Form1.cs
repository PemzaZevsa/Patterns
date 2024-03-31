using System.Diagnostics;

namespace FrontController
{
    public partial class Form1 : Form
    {
        Client client;
        public Form1()
        {
            InitializeComponent();
            var handler = new Handler();
            client = new Client(handler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.SendRequest("SET");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.SendRequest("POST");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.SendRequest("DELETE");
        }
    }
}
