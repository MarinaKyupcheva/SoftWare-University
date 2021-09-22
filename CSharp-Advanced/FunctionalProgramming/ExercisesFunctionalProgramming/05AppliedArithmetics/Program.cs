using System;
using System.Collections.Generic;
using System.Linq;

namespace _05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            Func<int, int> changedNumbers = n => n;
            Action<List<int>> printNumbers = nums => Console.WriteLine(string.Join(" ", nums));

            while (command != "end")
            { 
                if(command == "add")
                {
                    changedNumbers = n => n + 1;
                    numbers = numbers.Select(changedNumbers).ToList();

                }
                else if(command == "multiply")
                {
                    changedNumbers = n => n * 2;
                    numbers = numbers.Select(changedNumbers).ToList();
                }
                else if(command == "subtract")
                {
                    changedNumbers = n => n - 1;
                    numbers = numbers.Select(changedNumbers).ToList();
                }
                else
                {
                    printNumbers(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
