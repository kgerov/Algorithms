using System;

namespace _02.NestedLoopsToRecursion
{
    class NestedLoopsToRecursion
    {
        static void Main()
        {
            Console.Write("Enter number of iterations: ");
            int numberOfIter = Int32.Parse(Console.ReadLine());

            NestedLoopRecursion(numberOfIter);
        }

        public static void NestedLoopRecursion(int numberOfIter, int currentNode = 1, int depth = 1, string currentNum = "")
        {
            if (depth <= numberOfIter)
            {
                for (int i = 1; i <= numberOfIter; i++)
                {
                    currentNum += i;
                    NestedLoopRecursion(numberOfIter, i, depth + 1, currentNum);
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