using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMP = new Dictionary<string, int>();

            int maxHP = 100;
            int maxMP = 200;

            for (int i = 0; i < n; i++)
            {
                string[] splited = Console.ReadLine().Split(" ");
                string heroName = splited[0];
                int hP = int.Parse(splited[1]);
                int mP = int.Parse(splited[2]);

                heroHP[heroName] = hP > maxHP ? maxHP : hP;
                heroMP[heroName] = mP > maxMP ? maxMP : mP;

                if (!heroHP.ContainsKey(heroName))
                {
                    heroHP.Add(heroName, hP);
                }
                if (!heroMP.ContainsKey(heroName))
                {
                    heroMP.Add(heroName, mP);
                }

            }
            string input = Console.ReadLine();

            while (input!= "End")
            {
                string[] cmdArg = input.Split(" - ");
                string command = cmdArg[0];
                string heroName = cmdArg[1];

                if(command == "CastSpell")
                {
                    int mPNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];

                    if(heroMP[heroName] > mPNeeded)
                    {
                        heroMP[heroName] -= mPNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMP[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if(command == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attaker = cmdArg[3];

                    heroHP[heroName] -= damage;
                    if(heroHP[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attaker} and now has {heroHP[heroName]} HP left!");

                    }
                    else
                    {
                        heroHP.Remove(heroName);
                        
                        Console.WriteLine($"{heroName} has been killed by {attaker}!");
                    }

                }
                else if(command == "Recharge")
                {
                    int amount = int.Parse(cmdArg[2]);
                    int before = heroMP[heroName];
                    heroMP[heroName] += amount;

                    if (heroMP[heroName] > maxMP)
                    {
                        heroMP[heroName] = maxMP;
                    }
                    int after = heroMP[heroName];
                    int totalMP = after - before;
                    Console.WriteLine($"{heroName} recharged for {totalMP} MP!");

                }
                else if(command == "Heal")
                {
                    int amount = int.Parse(cmdArg[2]);
                    int before = heroHP[heroName];
                    heroHP[heroName] += amount;

                    if(heroHP[heroName] > maxHP)
                    {
                        heroHP[heroName] = maxHP;
                        
                    }

                    int after = heroHP[heroName];
                    int totalHP = after - before;
                    Console.WriteLine($"{heroName} healed for {totalHP} HP!");
                }

                input = Console.ReadLine();
            }
            foreach (var hero in heroHP.OrderByDescending(x=>x.Value).ThenBy(k=>k.Key)
                .ToDictionary(k=>k.Key, v=>v.Value))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroMP[hero.Key]}");

            }
        }
    }
}
