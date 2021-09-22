using System;
using System.Collections.Generic;
using System.Linq;

namespace _03PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> plantsRarity = new Dictionary<string, double>();
            Dictionary<string, double> plantsRating = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] splited = Console.ReadLine().Split("<->");
                string plant = splited[0];
                double rarity = int.Parse(splited[1]);

                if (plantsRarity.ContainsKey(plant))
                {
                    plantsRarity[plant] += rarity;
                }
                else
                {
                    plantsRarity.Add(plant, rarity);
                }
            }
            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] cmdArg = input.Split(": ");
                string command = cmdArg[0];
                string plantt = cmdArg[1];

                if (command == "Rate")
                {
                    string[] cmd = plantt.Split(" - ");
                    string plant = cmd[0];
                    double rating = double.Parse(cmd[1]);

                    if (!plantsRating.ContainsKey(plant))
                    {
                        plantsRating.Add(plant, rating);
                    }
                    
                    

                  
                }
                else if(command == "Update")
                {
                    string[] cmd = plantt.Split(" - ");
                    string plant = cmd[0];
                    double newRarity = double.Parse(cmd[1]);

                    if (plantsRarity.ContainsKey(plant))
                    {
                        plantsRarity[plant] = newRarity;
                    }
                   
                    
                }
                else if(command == "Reset")
                {
                    string[] cmd = plantt.Split(" - ");
                    string plant = cmd[0];

                    if (plantsRating.ContainsKey(plant))
                    {
                        plantsRating[plant] = 0.00;
                    }
                    

                }
                else
                {
                    Console.WriteLine("error");
                }

                input = Console.ReadLine();
            }

            Dictionary<string, double> avrRating = new Dictionary<string, double>();

            foreach (var item in plantsRating)
            {
                if(item.Value > 0)
                {
                    avrRating.Add(item.Key,item.Value.Avarage)
                }

            }

            Console.WriteLine($"Plants for the exhibition:");

            var plants = plantsRarity.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, v => v.Value);

            foreach (var plant in plants)
            {
              
                Console.WriteLine($"- { plant.Key}; Rarity: {plant.Value}; Rating: { plantsRating[plant.Key]}");
            }
        }
    }
}
