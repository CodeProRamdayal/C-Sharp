using System;

namespace Csharp_Tutorials.Loop
{
    class LoopBasic
    {
        public static void BasicLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("I ve had enough!");
                    break;
                }
            }
        }
    }
}