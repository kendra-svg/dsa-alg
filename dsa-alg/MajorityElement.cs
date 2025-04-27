using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dsa_alg
{
    public class MajorityElement
    {
        public int Find() //Given an array, find the element that appears more than n/2 times. 
        {

        //NOTES: n is the size of the array, it would be necessary to find and element that appears more then n / 2 times,meaning: majority + 1.
        //If the total size is 100, then n/2 is 50, since we need a number to be greater than that, it starts at 51. Thats the textbook definition of 'majority'

            int[] A = { 3, 4, 2, 4, 2, 4, 4 };
            int count = 0;
            int canditate = 0;

            foreach (int num in A)
            {
                if (count == 0)
                {
                    canditate = num;
                }
                count += (num == canditate) ? 1 : -1; // if (num == candidate) is true, then add 1 to count --> count = count +1;. else (if num != candidate), then substract 1 from the count -->  count = count -1;
            }

            return count > A.Length / 2 ? canditate : -1; //if (count > A.Length / 2 ) [if count is bigger than half the array size], then the candidate is valid --> return candidate. Else, [no element is bigger than half the array size], the candidate is not valid --> return -1.

            //Optimized approach: Boyer-Moore Voting Algorithm. Time Complexity: O(n), space complexity: O(1)
        }
    }
}
