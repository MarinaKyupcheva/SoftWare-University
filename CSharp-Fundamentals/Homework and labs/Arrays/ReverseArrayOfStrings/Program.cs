using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length/2; i++)
            {
                string tepm = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = tepm;

               
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
