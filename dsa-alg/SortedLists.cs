using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_alg
{
    public class SortedLists
    {
        public List<int> ListSorterBruteForce()
        {
            List<int> list1 = [1, 3, 9, 6, 8];
            List<int> list2 = [2, 9, 6, 5, 46, 85];
            List<int> list3 = [];

            foreach (int number in list2)
            {
                if (!list1.Contains(number)) //list.Contains() is O(n)
                {

                    list3.Add(number); //O(1)
                }
            }
            list3.AddRange(list1); //O(n)
            list3.Sort(); //O(n log n)
            return list3;

            //This is a brute force approach because foreach number in list2, the code checks if it's in list1
            //Thats 6 items (in list2) x 5 checks (in list1)= up to 30 checks --> O(n * m)
            //Not terrible at small sizes, but it wont scale well.

            //Let's assume list1 has n elements, and list2 has m elements
            //Time complexity: Brute Force

            //1. Loop through list2: O(m)
            //2. For each number in list2, list1.Contains(number) is a linear search: O(n)
            //Together: O(n * m)
            //3. list3.AddRange(list1): O(n)
            //4. list3.Sort(): Sortin n + x items --> let's call the final list size k, then it's O(k log k)

            //Final time complexity:
            //O(n * m + k log k)
        }

        public List<int> ListSorterOptimizedApproach() //Time complexity: O(n * m + k log k)
        {
            List<int> list1 = [1, 5, 9, 16, 45, 78, 90];
            List<int> list2 = [2, 6, 10, 23, 57, 69, 100];

            HashSet<int> set1 = new HashSet<int>(list1);

            List<int> list3 = [];

            foreach (int num in list2)
            {
                if (!set1.Contains(num))
                {
                    list3.Add(num);
                }
            }
            list3.AddRange(list1);
            list3.Sort();
            return list3;
        }

        public List<int> ListSorterRefactoredOptimizedApproach() //Time complexity = O(n + m)
        {
            List<int> list1 = [1, 2, 5, 9, 16, 45, 78, 90];
            List<int> list2 = [2, 6, 10, 23, 57, 69, 100];

            List<int> list3 = new();

            int i = 0, j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] < list2[j])
                {
                    list3.Add(list1[i]);
                    i++;
                }

                else if (list1[i] > list2[j])
                {
                    list3.Add(list2[j]);
                    j++;
                }

                else // list1[i] == list2[j]
                {
                    list3.Add(list1[i]);
                    i++;
                    j++;
                }
            }

            //Add any remaining elements from either list

            while (i < list1.Count)
            {
                list3.Add(list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                list3.Add(list2[j]);
                j++;
            }

            return list3;
        }
    }
}
