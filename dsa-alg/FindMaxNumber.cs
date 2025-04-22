using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_alg
{
    public class FindMaxNumber
    {
        public int FindMaxNumberInArray()
        {
            //Brute force solution
            Random rndm = new Random();
            int numbers = rndm.Next(1, 100);
            int[] numbersArray = new int[10];


            for (int i = 0; i < numbersArray.Length; i++)
            {
                //For each iteration a random number is added to the array until the array's length is hit. In this case is 10, so the last index would be 9.
                numbersArray[i] = rndm.Next(1, 100);
            }

            var arrayToList = numbersArray.ToList();
            arrayToList.Sort();

            return arrayToList[9];

        }
    }
}
