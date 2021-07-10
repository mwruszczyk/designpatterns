﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
