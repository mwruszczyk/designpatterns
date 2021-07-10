using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    class BridgeRun
    {
        public BridgeRun()
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            Console.ReadKey();
        }

       
    }
}
