using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace dsa_alg
{
    public class DuplicatesOnSortedArray
    {
        public int[] Remove() //time and space complexity of O(n)
        {
            int[] A = { 1, 1, 1, 1, 1, 3, 4, 6, 7 };

            int i = 0; // keeps track of the last unique element index
            for (int j = 1; j < A.Length; j++) // j moves forward scanning for new unique values
            {
                if (A[j] != A[i])
                {
                    i++;
                    A[i] = A[j];
                }
            }


            int[] result = new int[i + 1];
            Array.Copy(A, result, i + 1); //copy method takes sourceArray, destinationArray and desired length of new destination array

            var response = string.Join(Environment.NewLine, result);
            Console.WriteLine(response);

            return result;
        }

        public int[] RemoveUsingLists() //Overall time complexity O(n)
        {
            int[] A = { 1, 1, 1, 1, 1, 3, 4, 6, 7 };
            List<int> list = new List<int>(A); //Array is tuened into list

            List<int> finalList = new List<int>(); //It will store unique elements
            HashSet<int> seen = new HashSet<int>(); //To check if we already saw the number

            foreach (int num in list)
            {
                if (!seen.Contains(num))
                {
                    seen.Add(num);
                    finalList.Add(num);
                }
            }
            return finalList.ToArray();

            //This is not the best solution because I started with an array, and immediately after I copied it into a list (duplicating memory), then I created two more structures (seen HashSet) and (finalList list). 

            //Extra transformations: I turned it into an array, then into a list, then into an array again, which is wasted effort.

            //Long story short, I was doing extra copying, extra memory usage, and extra transformations that could be avoided by either working direclty on the array or by using onlu a hashset and a new List without copying the original array into a list.
        }


    }
}
