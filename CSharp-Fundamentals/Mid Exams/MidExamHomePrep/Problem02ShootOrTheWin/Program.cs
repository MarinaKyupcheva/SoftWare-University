using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Problem02ShootOrTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int counter = 0;

            string input = Console.ReadLine();

            while (input?.ToLower() != "end")
            {
                int tokens = int.Parse(input);

                if(tokens < 0 || tokens >= targets.Length || targets[tokens] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                int index = targets[tokens];
                targets[tokens] = -1;
                counter++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if(targets[i] == -1)
                    {
                        continue;
                    }
                    if(targets[i] > index)
                    {
                        targets[i] -= index;
                    }
                    else
                    {
                        targets[i] += index;
                    }
                }



                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: { counter} -> {string.Join(" ", targets)}");
        }
    }
}