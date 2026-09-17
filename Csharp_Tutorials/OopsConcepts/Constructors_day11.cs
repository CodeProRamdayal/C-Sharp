using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.OopsConcepts
{
    internal class Constructors_day11
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public Constructors_day11(string name)
        {
            Name = name != "" ? name : "Default Name";
        }

        public Constructors_day11(string name, string address, string mobile) 
        {
            Name = name != ""? name: "Default Name";
            Address = address != ""?address:"Default Address";
            Mobile = mobile !=""? mobile:"5556632";
        }

    }
}
