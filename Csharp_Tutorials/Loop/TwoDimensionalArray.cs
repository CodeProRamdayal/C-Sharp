using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Loop
{
    public class TwoDimensionalArray
    {
        public static void BasicTwoDimensionalArray()
        {
            // Declare a two-dimensional array of integers with 3 rows and 4 columns
            //    int[,] my2DArray = new int[3, 4];
            //    // Initialize the array with values
            //    my2DArray[0, 0] = 1;
            //    my2DArray[0, 1] = 2;
            //    my2DArray[0, 2] = 3;
            //    my2DArray[0, 3] = 4;
            //    my2DArray[1, 0] = 5;
            //    my2DArray[1, 1] = 6;
            //    my2DArray[1, 2] = 7;
            //    my2DArray[1, 3] = 8;
            //    my2DArray[2, 0] = 9;
            //    my2DArray[2, 1] = 10;
            //    my2DArray[2, 2] = 11;
            //    my2DArray[2, 3] = 12;
            //    // Print the elements of the two-dimensional array
            //    for (int i = 0; i < my2DArray.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < my2DArray.GetLength(1); j++)
            //        {
            //            Console.Write(my2DArray[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }

            int[,] myArray2D = { { 1, 2 }, { 3, 4 } };

            for (var i = 0; i < myArray2D.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2D.GetLength(1); j++)
                {
                    Console.Write(myArray2D[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
