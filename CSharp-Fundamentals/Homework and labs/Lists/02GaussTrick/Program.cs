using System;
using System.Collections.Generic;
using System.Linq;

namespace _02GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int originalNumber = numbers.Count / 2;

            for (int i = 0; i < originalNumber; i++)
            {

                numbers[i] += numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);

                    
            }
            Console.WriteLine(string.Join (" ", numbers));
        }
    }
}
