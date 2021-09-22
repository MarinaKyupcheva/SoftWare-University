using System;
using System.Linq;

namespace _04AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x + (x*0.20))
                .ToArray();

            foreach (var price in input)
            {
                Console.WriteLine($"{ price:f2}");
            }
        }
    }
}
