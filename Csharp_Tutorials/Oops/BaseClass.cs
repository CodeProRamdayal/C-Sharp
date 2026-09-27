using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Oops
{
    public class BaseClass
    {
        // Virtual Keyword: The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
        public virtual void DisaplayMyName()
        {
            Console.WriteLine("Hello My Name is Base Class");
        }

        public virtual void GetSum(int a, int b)
        {
            Console.WriteLine($"sum {a+b}");
        }

    }

   public class DrivedClass : BaseClass
    {

        public override void DisaplayMyName()
        {
            Console.WriteLine("I am drived class");
        }

        public sealed override void GetSum(int a, int b)
        {
            base.GetSum(a,b);

        }

    }

    public class SubDrivedClass : DrivedClass{ 
    
      
    }

}
