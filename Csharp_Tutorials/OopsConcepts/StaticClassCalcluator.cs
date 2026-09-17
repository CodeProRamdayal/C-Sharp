using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.OopsConcepts
{
    internal static class StaticClassCalcluator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Muliply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
