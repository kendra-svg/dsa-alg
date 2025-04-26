using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_alg
{
    public class MissingNumberFromArray
    {
        public int Finder()
        {
            int[] array = [0, 1, 2, 3, 5, 6, 7, 8, 9];
            int n = array.Length;

            int expectedSum = n * (n + 1) / 2; //Gauss formula. Aka as "formula de suma de progresion aritmetica o formula de la suma de los primeros n numeros naturales". 

            int actualSum = 0;
            foreach (int num in array)
            {
                actualSum += num;
            }
            return expectedSum - actualSum;
        }
    }
}
