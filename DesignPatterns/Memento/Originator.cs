using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    class Originator
    {
        string state;
        
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }


        public Memento CreateMemento()
        {
            return (new Memento(state));
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state ...");
            State = memento.State;
        }

    }
}
