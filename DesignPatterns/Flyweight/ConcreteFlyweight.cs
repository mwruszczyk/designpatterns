using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsictate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsictate);
        }
    }
}
