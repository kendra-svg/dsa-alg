using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_alg
{
    public class Palindrome
    {
        public bool isPalindrome()
        {
            string userInput = Console.ReadLine();

            int left = 0;
            int right = userInput.Length - 1;

            while (left < right)
            {
                Console.WriteLine($"Comparing input[{left}] = '{userInput[left]}' with input[{right}] = '{userInput[right]}'");
                if (userInput[left] != userInput[right])
                {
                    Console.WriteLine("Characters don't match. Not a palindrome. ");
                    return false;

                }
                left++;
                right--;

            }
            Console.WriteLine("All characters pair match. It is a palindrome.");
            return true;
        }
    }
}
