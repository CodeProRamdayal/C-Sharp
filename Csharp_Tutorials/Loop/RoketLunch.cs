using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Loop
{
    public class RoketLunch
    {
        public static void Lunch()
        {

            string rocket = "     |\r\n" +
                            "     |\r\n" +
                            "    / \\\r\n" +
                            "   / _ \\\r\n" +
                            "  |.o '.|\r\n" +
                            "  |'._.'|\r\n" +
                            "  |     |\r\n" +
                            " ,'|  |  |'.\r\n" +
                            "/  | | |  \\\r\n" +
                            "|,-'--|--'-.|";
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("I is " + i);
                Console.WriteLine(rocket);
                rocket = "\r\n" + rocket;
                Thread.Sleep(1000);
            }
            Console.WriteLine("The rocket has landed!");
        }
    }
}
