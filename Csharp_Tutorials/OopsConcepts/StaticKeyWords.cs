using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.OopsConcepts
{
    internal class StaticKeyWords
    {
        public static int CountInstances = 0;
         
        public StaticKeyWords()
        {
            CountInstances++;
        }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get { return Width * Height; }
        }

        public static int DoubleValue(int value)
        {
            return value * 2;
        }

        // Operator overloading for the + operator

        // Operator overloading for the + operator
        public static StaticKeyWords operator +(StaticKeyWords rect1, StaticKeyWords rect2)
        {
            return new StaticKeyWords
            {
                Width = rect1.Width + rect2.Width,
                Height = rect1.Height + rect2.Height
            };
        }
        // Operator overloading for the * operator
        public static StaticKeyWords operator  *(StaticKeyWords value1, StaticKeyWords value2)
        {
            return new StaticKeyWords
            {
                Width = value1.Width * value2.Width,
                Height = value1.Height * value2.Height
            };
        }
    }
}
