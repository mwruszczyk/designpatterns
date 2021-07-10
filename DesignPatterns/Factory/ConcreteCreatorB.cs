using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
