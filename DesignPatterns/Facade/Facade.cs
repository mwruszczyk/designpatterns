﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {

            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }


        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ----");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
