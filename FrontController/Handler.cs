using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontController
{
    public class Handler
    {
        public List<ICommand> comands;
        public Handler()
        {
            comands = new List<ICommand>();
            comands.Add(new GetCommand());
            comands.Add(new PostCommand());
            comands.Add(new DeleteCommand());
        }
        public void HandleRequest(string request)
        {
            switch (request)
            {
                case "SET":
                    comands[0].Execute();
                    break;
                case "POST":
                    comands[1].Execute();
                    break;
                case "DELETE":
                    comands[2].Execute();
                    break;
            }
        }
    }
}
