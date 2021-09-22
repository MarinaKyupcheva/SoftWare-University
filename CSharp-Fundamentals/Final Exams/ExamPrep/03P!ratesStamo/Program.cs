using System;
using System.Collections.Generic;
using System.Linq;

namespace _03P_ratesStamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> towns = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Sail")
            {
                string[] cmdArg = command.Split("||");
                string town = cmdArg[0];
                int population = int.Parse(cmdArg[1]);
                int gold = int.Parse(cmdArg[2]);

                if (towns.ContainsKey(town))
                {
                    towns[town]["population"] += population;
                    towns[town]["gold"] += gold;
                }
                else
                {
                    towns.Add(town, new Dictionary<string, int>());
                    towns[town].Add("population", population);
                    towns[town].Add("gold", gold);
                    
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split("=>");
                string cmd = cmdArg[0];
                string town = cmdArg[1];

                if(cmd == "Plunder")
                {
                    int people = int.Parse(cmdArg[2]);
                    int gold = int.Parse(cmdArg[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    towns[town]["population"] -= people;
                    towns[town]["gold"] -= gold;

                    if(towns[town]["population"] <= 0 || towns[town]["gold"] <= 0)
                    {
                        towns.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                else if(cmd == "Prosper")
                {
                    int gold = int.Parse(cmdArg[2]);

                    if(gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        int totalGold = towns[town]["gold"] + gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {totalGold} gold.");
                        
                    }
                    

                }
                command = Console.ReadLine();
            }

            if(towns.Count > 0)
            {
                towns = towns.OrderByDescending(x => x.Value["gold"]).ThenBy(t => t.Key)
                    .ToDictionary(x => x.Key, v => v.Value);

                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");

                foreach (var town in towns)
                {
                    int people = town.Value["population"];
                    int gold = town.Value["gold"];
                    Console.WriteLine($"{town.Key} -> Population: {people} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
