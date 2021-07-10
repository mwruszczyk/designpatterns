using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class Target
    {
        public  virtual void Request()
        {
            Console.WriteLine("Called Target Request");
        }
    }
}
