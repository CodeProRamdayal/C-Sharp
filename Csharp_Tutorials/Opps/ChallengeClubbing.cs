using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Opps
{
    public class ChallengeClubbing
    {
       public static void ISAllowedClubbing()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            bool isWithParent = true;
            //if (age < 18 && isWithParent)
            //{
            //    Console.WriteLine("You can enter the club with your parent.");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("You can enter the club.");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot enter the club.");
            //}
            switch (age)
            {
                case int _ when age < 18 && isWithParent:
                    Console.WriteLine("You can enter the club with your parent.");
                    break;
                case int _ when age >= 18:
                    Console.WriteLine("You can enter the club.");
                    break;
                 default: Console.WriteLine("You cannot enter the club.");
                    break;
            }
        }
  }
  
}
