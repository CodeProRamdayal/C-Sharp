using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Predicate_Delegate
{
    internal class BubbleSort
    {
      public static void BubbleSortExamlpe(int[] arr)
        {
            int length = arr.Length;
            int counter = 0;
            int largestElement = arr[0];
            bool swapped = false;

            for(int i=0; i < length-1 ; i++)
            {
                swapped = false;
                counter++;
                for(int j = 0; j < length - i - 1; j++) {
                    if (arr[j]> arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        swapped = true;
                    }
                }
                        //if(counter ==  1)
                        //{
                        //    largestElement = arr[length-1];
                        //    break;
                        //}
            }

            //Console.WriteLine("Largest element: " + largestElement);

           PrintArray(arr);

        }


        // generic version of bubble sort

        static void PrintArray<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
