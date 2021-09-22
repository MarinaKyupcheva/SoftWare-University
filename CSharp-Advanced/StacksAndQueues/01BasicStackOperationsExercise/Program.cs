using System;
using System.Collections.Generic;
using System.Linq;

namespace _01BasicStackOperationsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> result = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                result.Push(numbers[i]);
            }

            for (int j = 0; j < s; j++)
            
            {
                result.Pop();
            }

            
                if (result.Contains(x))
                {
                    Console.WriteLine($"true");
                }

            else if (!result.Any())
            {
                Console.WriteLine(0);
            }
            else
                {
                    Console.WriteLine(result.Min());
                }
            
          
            
                
        }
    }
}
