using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Loop
{
    public class ArrayBasic
    {
        public static void BasicArray()
        {
            // Declare an array of integers with a size of 5
            //int[] myIntArray = new int[5];
            //myIntArray[0] = 1;
            //myIntArray[2] = 20;
            //myIntArray[3] = 30;
            //Console.WriteLine(myIntArray);

            int[] myIntArray = [10, 20, 30, 40, 50];

            string[] weekdays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine("Array elements : {0} ", myIntArray[i]);
            }

            //for (int i = 0; i < weekdays.Length; i++)
            //{
            //    if (weekdays[i].ToLower() == "sunday" || weekdays[i].ToLower() == "saturday")
            //    {
            //        Console.WriteLine("Weekend : {0} ", weekdays[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Weekday : {0} ", weekdays[i]);
            //    }
            //}

            foreach (string day in weekdays)
            {
                if (day.ToLower() == "sunday" || day.ToLower() == "saturday")
                {
                    Console.WriteLine("Weekend : {0} ", day);
                }
                else
                {
                    Console.WriteLine("Weekday : {0} ", day);
                }
            }
        }
    }
}
