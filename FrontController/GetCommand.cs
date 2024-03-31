using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontController
{
    public class GetCommand : ICommand
    {
        public void Execute()
        {
            Debug.WriteLine("Выполнение GET запроса");
        }
    }
}
