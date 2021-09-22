using System;
using System.Collections.Generic;

namespace _03PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> plants = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string plant = input[0];
                string rarity = input[1];

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, rarity);
                }
                else
                {
                    plants[rarity] += rarity;
                }
            }

            string cmd = Console.ReadLine();
            while (cmd != "Exhibition")
            {
                string[] cmdArg = cmd.Split(" ");
                string command = cmdArg[0];
                string plant = cmdArg[1];

                if(command == "Rate:")
                {

                }


                cmd = Console.ReadLine();
            }
        }
    }
}
