using System;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()?.Split(", ").Select(int.Parse).ToArray();

            Lake lake = new Lake(stones);

            Console.WriteLine(string.Join(", ", lake));

        }
    }
}
