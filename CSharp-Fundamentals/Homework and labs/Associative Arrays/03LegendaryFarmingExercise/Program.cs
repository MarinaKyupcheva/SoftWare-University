using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LegendaryFarmingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            bool haveToBreak = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if(keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;

                            if(material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            haveToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }
                }
                if (haveToBreak)
                {
                    break;
                }

            }
            Dictionary<string, int> filteredKeyMaterials = keyMaterials
                .OrderByDescending(a => a.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(v => v.Key, v => v.Value);
            foreach (var kvp in filteredKeyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterials.OrderBy(k=>k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
