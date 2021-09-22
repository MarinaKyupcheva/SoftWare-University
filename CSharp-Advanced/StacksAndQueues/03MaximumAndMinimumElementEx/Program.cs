using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaximumAndMinimumElementEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Stack<int> result = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = input[0];

                if (command == 1)
                {
                    int number = input[1];
                    result.Push(number);
                }
               else if (result.Any())
                {
                   if (command == 2)
                    {
                        result.Pop();
                    }

                    else if (command == 3)
                    {
                        Console.WriteLine(result.Max());
                    }
                    else if (command == 4)
                    {
                        Console.WriteLine(result.Min());
                    }
                }
               

            }



            Console.WriteLine(string.Join(", ", result));



        }
    }
}
