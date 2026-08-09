using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.QuizApp
{
    public class InBuildMethods
    {
        public static void GenerateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11); // Generates a random number between 1 and 10
            Console.WriteLine("Guess the number (1-10):");
            int num1 = 0;
            string inputNumber = Console.ReadLine();

            bool isNumber = int.TryParse(inputNumber, out num1);

            if (isNumber)
            {
                if (num1 == randomNumber)
                {
                    Console.WriteLine("You guessed right!");
                }
                else
                {
                    Console.WriteLine("You guessed wrong!, try again!");
                }
            }
            else
            {
                Console.WriteLine("Haha you troll. You didn't enter a number!");
            }

        }

}
}
