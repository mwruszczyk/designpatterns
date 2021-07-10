using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    class InterpreterRun
    {
        public InterpreterRun()
        {
            Context context = new Context();

            List<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression()); 
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadKey();
        }
    }
}
