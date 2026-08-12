using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Arrays
{
    internal class SingleDArray
    {
        public  void UserInputArray(out int[] arr)
        {
            int[] inputArr = new int[5];
            Console.WriteLine("Enter the 5 number");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                inputArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arr = inputArr; 
        }
    }
}
