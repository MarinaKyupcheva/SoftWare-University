using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split("|").ToList();

            numbers.Reverse();

            List<string> result = new List<string>();

            foreach (string item in numbers)
            {
                string[] currentArray = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string numbersToAdd in currentArray)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
