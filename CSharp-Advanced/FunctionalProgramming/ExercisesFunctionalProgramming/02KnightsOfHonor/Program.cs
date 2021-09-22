using System;
using System.Linq;

namespace _02KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ").ToArray();
            names = names.Select(n => $"Sir {n}").ToArray();

            Action<string[]> printNames = a => Console.WriteLine(string.Join(Environment.NewLine, a));

            printNames(names);
        }
    }
}
