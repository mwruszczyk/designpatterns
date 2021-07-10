using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class ProxyRun
    {
        public ProxyRun()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
            Console.ReadKey();
        }
    }
}
