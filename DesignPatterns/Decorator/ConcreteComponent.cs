﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
