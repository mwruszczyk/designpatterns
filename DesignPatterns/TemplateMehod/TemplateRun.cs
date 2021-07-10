using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMehod
{
    class TemplateRun
    {
        public TemplateRun()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            // Wait for user
            Console.ReadKey();
        }
       
    }
}
