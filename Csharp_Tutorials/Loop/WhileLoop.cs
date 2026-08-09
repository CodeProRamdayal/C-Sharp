using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Loop
{
    public class WhileLoop
    {
        public static void GuessNumeber()
        {
            string dNumber = "54657865465.9999";
            int outPutResult;
            int.TryParse(dNumber, out outPutResult);
            Console.WriteLine(">>>>>>>>>>> {0}", outPutResult);
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            Console.WriteLine("numberToGuess: {0}", numberToGuess);
            int secretNumber = 40;

            while (numberToGuess != secretNumber)
            {
                Console.WriteLine("try again");
                numberToGuess = int.Parse(Console.ReadLine());
            }
        }
    }
}
