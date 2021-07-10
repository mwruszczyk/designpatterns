﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
