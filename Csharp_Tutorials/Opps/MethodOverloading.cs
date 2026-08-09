using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Opps
{
    public class MethodOverloading
    {
        // Ref Modifier; 
        // WIthout ref modifier, the value of a will be changed in the calling method.
        public static void Add(int a)
        {
            a += 2;
        }
        // With ref modifier, the value of a will be changed in the calling method.
        public static void Add(ref int a)
        {
            a += 2;
        }


    }
   
}
