using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_alg
{
    public class PivotInIndex
    {
        public int Finder() //Time and space complexity: O(n)
        {
            int[] array = [5, 1, 4, 3, 6, 8, 10, 7, 9];
            int n = array.Length; //Size of the array

            if (n == 0) return -1;

            int[] leftMax = new int[n];
            int[] rightMin = new int[n];

            //Build leftMax
            leftMax[0] = array[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], array[i]); //Gets filled from left to right, so at each index, we keep track of the largest number we've seen so far.
            }

            //Build rightMin
            rightMin[n - 1] = array[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMin[i] = Math.Min(rightMin[i + 1], array[i]); //Gets filled from right to left, so at each index, we keep track of the smallest number we've seen so far.
            }

            //Check for pivot
            for (int i = 1; i < n - 1; i++)
            {
                if (leftMax[i] == array[i] && rightMin[i] == array[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
