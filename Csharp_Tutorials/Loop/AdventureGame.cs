using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Loop
{
    public class AdventureGame
    {
        public static void StartGame()
        {
            Console.WriteLine("Welcome to the Adventure Game!");
            Console.WriteLine("Enter Your Character's name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Choose Your Character type (Warrior, Wizard, Archer): ");
            string characterType = Console.ReadLine();
            Console.WriteLine($"You, {playerName}, have chosen to be a {characterType}!");
            Console.WriteLine("Do you want to enter the forest or camp outside? (Enter / Camp) ");

            string choice = Console.ReadLine();
            if (choice.ToLower() == "enter")
            {
                Console.WriteLine("You bravely enter the forest...");
            }
            else
            {
                Console.WriteLine("You decide to camp outside for the night.");
            }
            bool gameContinues = true;
            while (gameContinues)
            {

                Console.WriteLine("You encounter a wild beast! Do you want to fight or run? (Fight / Run)");
                string action = Console.ReadLine();
                if (action.ToLower() == "fight")
                {
                    Random random = new Random();
                    int luck = random.Next(1, 11); // Random number between 1 and 10
                    if (luck > 5)
                    {
                        Console.WriteLine("You bravely fight the beast and win!");
                        if (luck > 8)
                        {
                            Console.WriteLine("The wild beast dropped a treasure!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("The wild beast is too powerful! You barely escape with your life.");

                    }
                }
                else
                {
                    Console.WriteLine("You run away safely.");
                }

                //else if (direction.ToLower() == "right")
                //{
                //    Console.WriteLine("You find a treasure chest! Do you want to open it? (Yes / No)");
                //    string action = Console.ReadLine();
                //    if (action.ToLower() == "yes")
                //    {
                //        Console.WriteLine("You open the chest and find gold!");
                //    }
                //    else
                //    {
                //        Console.WriteLine("You leave the chest untouched.");
                //}
                //}
            }
        }
    }
}