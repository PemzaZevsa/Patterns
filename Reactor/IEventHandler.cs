﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactor
{
    public interface IEventHandler
    {
        void HandleEvent(Event e);
    }
}
