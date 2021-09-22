using System;
using System.Collections.Generic;
using System.Linq;

namespace _09ForceBookExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> order = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while(input != "Lumpawaroo")
            {

                string[] cmdArg1 = input.Split(" | ");
                string forceSide = cmdArg1[0];
                string forceUser = cmdArg1[1];

                string[] cmdArg2 = input.Split(" -> ");
                string forceUser2 = cmdArg2[0];
                string forceSide2 = cmdArg2[1];

                if (!order.ContainsKey(forceUser))
                {
                    order.Add(forceUser, new List<string> { forceSide });
                }
                if (order.ContainsKey(forceUser2))
                {
                    order[forceSide2].Remove(forceSide);
                    order[forceSide2].Add(forceSide2);
                }
                else
                {
                    order.Add(forceUser2, new List<string> { forceSide2 });
                    Console.WriteLine($"{forceUser} joins the { forceSide} side!");
                }


                input = Console.ReadLine();
            }
            var newOrder = order.OrderByDescending(v => v.Value.Count).ThenBy(k => k.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in newOrder)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var itemm in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"! {itemm}");
                }
            }
        }
    }
}
