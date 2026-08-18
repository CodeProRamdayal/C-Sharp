using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.OopsConcepts
{
    internal class Car
    {
        private string _model = "";
        private string _brand = "";
        private string _name = "";
        private int age = 0;
        private bool buyCar;

        public Car(string name, string model, string brand)
        {
            Name = name;
            Model = model;
            Brand = brand;
            Console.WriteLine("Name : {0} Model : {1}  Brand : {2}",_name,_model,_brand);
        }

  
        public string Name { get => _name; set => _name = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int Age { get => age; set => age = value; }
        public bool BuyCar { get{
                if (Age > 18)
                {
                    return true;
                }
                else { return false; }
            }
            set => buyCar = value; }


        public static void MyCarDetail(out string name,out int amount)
        {
            name = "My Brand Car";
            amount =1000;
        }

        public static void MyBikeDetail(ref string bikeName, ref int amount)
        {

            bikeName = "Classic 350";
            amount = 30000;

        }
    }
}
