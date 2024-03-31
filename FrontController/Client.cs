using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontController
{
    public class Client
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
