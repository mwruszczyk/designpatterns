using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    class SingletonRun
    {
        public SingletonRun()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();


            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            Console.ReadKey();
        }
    }
}
