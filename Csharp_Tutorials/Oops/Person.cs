using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Oops
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine(" Hi i am Person class");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name : {Name} and Age : {Age}");
        }
    }
}
