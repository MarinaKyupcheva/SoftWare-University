using System;
using System.Linq;

namespace _04LargestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] sorted = list.OrderByDescending(n => n).ToArray();
            int count = sorted.Length >= 3 ? 3 : sorted.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{sorted[i] + " "}");
            }
        }
    }
}
