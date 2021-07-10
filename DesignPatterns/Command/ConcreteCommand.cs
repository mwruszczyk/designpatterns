﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {

        }

        public override void Execute()
        {
            receiver.Action();
        }

    }
}
