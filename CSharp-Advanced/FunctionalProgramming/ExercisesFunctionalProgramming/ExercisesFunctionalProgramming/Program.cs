using System;
using System.Linq;

namespace ExercisesFunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string[]> printNames = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            printNames(input);
         }
    }
}
