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

        


    }
}
