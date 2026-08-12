using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Methods
{
    internal class Methods
    {
        public int FindMax(int[] arr, out int maxElement)
        {
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            maxElement = max;
            return maxElement;
        }


       internal int Factorial(int n)
        {
            int result = 0;
            if (n == 0 || n == 1) return 1;
            else
            {
              result = Factorial(n - 1) * n;
              return result;
            }

        }
    }
}
