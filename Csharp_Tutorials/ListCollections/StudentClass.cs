using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.ListCollections
{
    internal class StudentClass
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public StudentClass(int id, string name, int age, string email)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

    }
}
