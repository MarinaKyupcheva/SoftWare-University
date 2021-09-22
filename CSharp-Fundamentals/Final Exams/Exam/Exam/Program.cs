using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            List<int> sets = new List<int>();
            while (hats.Count > 0 && scarfs.Count > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if(hat > scarf)
                {
                    int set = hat + scarf;
                    sets.Add(set);
                    hats.Pop();
                    scarfs.Dequeue();
                }

                else if(scarf > hat)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    int currentHat = hats.Pop();
                    hats.Push(currentHat + 1);
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine($"{string.Join(" ", sets)}");
        }
    }
}
