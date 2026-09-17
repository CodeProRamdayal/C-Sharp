using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.OopsConcepts
{
    internal class IsandAsKeyword
    {
        private static string message = "Hello, World!";
        private  string numberMessage = "12345";
       public static object?  InstanceObj;
        public  IsandAsKeyword(Object obj)
        {
            InstanceObj = obj;

        }
        public static void CheckedValue()
        {
            if (message is string str)
            {
                Console.WriteLine("Check the value with Unchanged Reference: " + str);
                str = "Hello, Universe!";
                Console.WriteLine("Check the value Changed Reference: " + str + " and the original message: " + message);
            }
            else
            {
                Console.WriteLine("Value is not a string.");
            }

            if (InstanceObj is StaticClassCalcluator calculator)
            {
                Console.WriteLine("Object is of type StaticClassCalcluator." + calculator.Add(10,20));

            }
            else
            {
                Console.WriteLine("Object is not of type StaticClassCalcluator.");

            }
        }
    }
}
