using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Oops
{
    internal class Employee :Person
    {

        public Employee(string Name, int Age):base(Name,Age)
        {
            Console.WriteLine("Hi am Drived class for Employee");
        }
        public void GetProp()
        {
            Console.WriteLine(base.Age);
        }
    }
}
