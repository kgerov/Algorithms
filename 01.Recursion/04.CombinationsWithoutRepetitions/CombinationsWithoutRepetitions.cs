using System;

namespace _04.CombinationsWithoutRepetitions
{
    class CombinationsWithoutRepetitions
    {
        private static int n; // the set of numbers. From 1 to n, inclusive
        private static int k; // the number of elements we select from the set

        static void Main()
        {
            Console.Write("Enter n: ");
            n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter k: ");
            k = Int32.Parse(Console.ReadLine());

            FindCombinations();
        }

        public static void FindCombinations(int currentNode = 1, int depth = 1, string currentNum = "")
        {
            if (depth <= k)
            {
                int numberOfIter = currentNode;
                
                if (depth != 1)
                {
                    numberOfIter++;
                }

                for (int i = numberOfIter; i <= n; i++)
                {
                    currentNum += i;
                    FindCombinations(i, depth + 1, currentNum);
                    currentNum = currentNum.Substring(0, currentNum.Length - 1);
                }
            }
            else
            {
                Console.WriteLine(currentNum);
            }
        }
    }
}
