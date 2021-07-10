using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
