using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
