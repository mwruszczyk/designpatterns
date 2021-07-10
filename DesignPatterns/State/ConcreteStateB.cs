﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
