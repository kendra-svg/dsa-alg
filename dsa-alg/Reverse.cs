using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_alg
{
    public class Reverse
    {
        public string ReverseAString()
        {
            char[] charArray;
            string userInput = Console.ReadLine();
            charArray = userInput.ToCharArray();

            Array.Reverse(charArray);
            Console.WriteLine($"The original input was {userInput}, and the output is: {new string(charArray)}");
            return new string(charArray);
        }
    }
}
