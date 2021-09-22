using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HeroesOfCodeAndLogicVIIMarina
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Dictionary<string, int>> heroes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            int maxHP = 100;
            int maxMP = 200;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string heroName = input[0];
                int HP = int.Parse(input[1]);
                int MP = int.Parse(input[2]);

                heroes[heroName]["HP"] = HP > maxHP ? HP : maxHP;
                heroes[heroName]["MP"] = MP > maxMP ? MP : maxMP;
                heroes.Add(heroName,new Dictionary<string, int>());
                heroes[heroName].Add("HP", HP);
                heroes[heroName].Add("MP", MP);

            }

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] cmdArg = cmd.Split(" - ");
                string command = cmdArg[0];
                string heroName = cmdArg[1];

                if(command == "CastSpell")
                {
                    int manaNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];

                    if(heroes[heroName]["MP"] > manaNeeded)
                    {
                        heroes[heroName]["MP"] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName]["MP"]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                   
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];

                    heroes[heroName]["HP"] -= damage;

                    if(heroes[heroName]["HP"] < 0)
                    {
                        Console.WriteLine($"{ heroName} has been killed by { attacker}!");
                        heroes.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName]["HP"]} HP left!");
                    }

                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(cmdArg[2]);
                    int hMBefore = heroes[heroName]["HM"];
                    heroes[heroName]["MP"] += amount;
                    if(heroes[heroName]["MP"] > maxMP)
                    {
                        heroes[heroName]["MP"] = maxMP;
                    }
                    int hMAfter = heroes[heroName]["HM"];
                    int total = hMBefore - hMAfter;
                    Console.WriteLine($"{heroName} recharged for {heroes[heroName]["MP"]} MP!");

                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(cmdArg[2]);
                    int hPBefore = heroes[heroName]["HP"];
                    heroes[heroName]["HP"] += amount;
                    if (heroes[heroName]["HP"] > maxMP)
                    {
                        heroes[heroName]["HP"] = maxMP;
                    }
                    int hPAfter = heroes[heroName]["HP"];
                    int total = hPBefore - hPAfter;
                    Console.WriteLine($"{heroName} recharged for {heroes[heroName]["HP"]} HP!");
                }

                cmd = Console.ReadLine();
            }
            foreach (var hero in heroes.OrderByDescending(x=> x.Value["HP"]).ThenBy(a=> a.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"HP: { hero.Value["HP"]}");
                Console.WriteLine($"MP: { hero.Value["MP"]}");
            }
        }
    }
}
