﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontController
{
    public class DeleteCommand : ICommand
    {
        public void Execute()
        {
            Debug.WriteLine("Выполнение DELETE запроса");
        }
    }
}
