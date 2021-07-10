using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) :base(id)
        {

        }

        //Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

    }
}
