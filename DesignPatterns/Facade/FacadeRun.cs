using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    class FacadeRun
    {

        public FacadeRun()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            Console.ReadKey();
        }
       

    }
}
