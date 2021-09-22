using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AMinerTaskExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string resourse = Console.ReadLine();
            
            Dictionary<string, int> collected = new Dictionary<string, int>();

            while(resourse != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!collected.ContainsKey(resourse))
                {
                    collected.Add(resourse, 0);
                }
                collected[resourse] += quantity;

                resourse = Console.ReadLine();
            }

            foreach (var r in collected)
            {
                Console.WriteLine($"{r.Key} -> {r.Value}");
            }
        }
    }
}
