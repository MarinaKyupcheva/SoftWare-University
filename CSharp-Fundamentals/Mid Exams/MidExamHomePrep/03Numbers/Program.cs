using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                double average = numbers.Average();
                
                
            }
            foreach (int num in numbers)
            {
                Console.WriteLine(numbers);
            }
            
        }
    }
}
