using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontController
{
    public class PostCommand : ICommand
    {
        public void Execute()
        {
            Debug.WriteLine("Выполнение POST запроса");
        }
    }
}
