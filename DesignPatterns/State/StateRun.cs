using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    class StateRun
    {
        public StateRun()
        {
            var context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();
        }
        

    }
}
