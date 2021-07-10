using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
