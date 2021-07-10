using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public abstract class Prototype
    {
        string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        public abstract Prototype Clone();
    }
}
