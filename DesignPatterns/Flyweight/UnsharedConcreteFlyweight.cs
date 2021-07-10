using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsictate)
        {
            Console.WriteLine("UsharedConcreteFlyweight: " + extrinsictate);
        }
    }
}
