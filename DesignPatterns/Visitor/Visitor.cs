using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(
            ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
            ConcreteElementB concreteElementB);
    }
}
