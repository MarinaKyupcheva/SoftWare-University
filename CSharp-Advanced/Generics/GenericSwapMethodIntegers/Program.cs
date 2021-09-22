using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> integers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                integers.Add(elements);
            }

            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Box<int> box = new Box<int>(integers);
            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box.ToString());

        }
    }
}
