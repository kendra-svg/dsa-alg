using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dsa_alg
{
    public class MajorityElement
    {
        public int Find() //Given an array, find the element that appears more than n/2 times. 
        {
            //Best approach: Boyer-Moore Voting Algorithm. Time Complexity: O(n), space complexity: O(1)

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


        }

        public int FindUsingDictionary() //This is the approach that I've liked the most so far. Dictionary lookups are O(1), you count all the number in one single pass, then one more pass to find which one has the highest count, overall time complexity of O(n) which is way faster and cleaner than using a list approach, for example FindUsingLists()
        {

            int[] A = { 3, 4, 2, 4, 2, 4, 4 };

            Dictionary<int, int> counts = new Dictionary<int, int>();
            //Dictionary is how it is called in C#, in Java is called HashMap and in python dict. All of them are based on the same concept. A key-value store where the key is hashed internally for super-fast lookup (almost O(1))

            foreach (int num in A)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 1;
                }
                else
                {
                    counts[num]++;
                }
            }
            int majorityCount = A.Length / 2;

            foreach (var pair in counts)
            {
                if (pair.Value > majorityCount)
                {
                    return pair.Key;
                }
            }

            return -1;


        }

        public int FindUsingLists() //Not smart at all. It involves multiple checks in each loop. Time complexity becomes almost O(n²)
        {
            int[] A = { 3, 4, 2, 4, 2, 4, 4 };

            List<int> uniqueNums = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!uniqueNums.Contains(A[i]))
                {
                    uniqueNums.Add(A[i]);
                }
            }

            int majorityCount = A.Length / 2;

            foreach (int candidate in uniqueNums)
            {
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == candidate)
                    {
                        count++;
                    }
                }

                if (count > majorityCount)
                {
                    return candidate;
                }
            }

            return -1;
        }

    }
}
