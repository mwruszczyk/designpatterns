using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    class ObserverRun
    {
        public ObserverRun()
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();
            Console.ReadKey();
        }
    }
}
