using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    class AdapterRun
    {
        public AdapterRun()
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadKey();
        }
    }
}
