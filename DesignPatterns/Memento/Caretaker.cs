using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class Caretaker
    {
        Memento memento;

        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
