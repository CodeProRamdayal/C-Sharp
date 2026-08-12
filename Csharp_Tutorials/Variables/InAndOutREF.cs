using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Variables
{
    public struct MyDetail
    {
        public int Id;
        public string Name;
    }
    internal class InAndOutREF
    {
        public void RefByValue(ref MyDetail obj) {
            Console.WriteLine($"Before changes Name: {obj.Name}, Id: {obj.Id}");
            obj.Name = "John";
            Console.WriteLine($"After changes Name: {obj.Name}, Id: {obj.Id}");
        }

        public void OutByValue(int num1, int num2, out int sum, out int product)
        {
            Console.WriteLine("Num 1: {0}, Num 2: {1}", num1, num2);
            sum = num1 + num2;
            product = num1 * num2;
            Console.WriteLine($"Sum: {sum}, Product: {product}");
        }

    }
}
