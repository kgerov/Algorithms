using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TowerOfHanoi
{
    class TowerOfHanoi
    {
        static void Main()
        {
            Console.Write("Number of disks: ");
            int numberOfDisks = Int32.Parse(Console.ReadLine());

            Stack<int> source = new Stack<int>(Enumerable.Range(0, numberOfDisks).Reverse());
            Stack<int> destination = new Stack<int>();
            Stack<int> spare = new Stack<int>();

            MoveDisks(numberOfDisks - 1, ref source, ref destination, ref spare);

            Console.WriteLine("Source count is: " + source.Count);
            Console.WriteLine("Destination count is: " + destination.Count);
            Console.WriteLine("Spare count is: " + spare.Count);
        }

        public static void MoveDisks(int disk, ref Stack<int> source, ref Stack<int> destination, ref Stack<int> spare)
        {
            if (disk == 0)
            {
                destination.Push(source.Pop());
            }
            else
            {
                MoveDisks(disk - 1, ref source, ref spare, ref destination);
                destination.Push(source.Pop());
                MoveDisks(disk - 1, ref spare, ref destination, ref source);
            }
        }
    }
}