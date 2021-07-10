using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatterns.Strategy
{
    public class StrategyRun
    {

        public StrategyRun()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }

    }
}
