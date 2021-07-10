using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    class MementoRun
    {
        public MementoRun()
        {
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";

            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
}
