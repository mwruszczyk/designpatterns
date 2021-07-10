using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
