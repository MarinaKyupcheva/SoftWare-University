using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HeroesofCodeandLogicVIIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var heroHp = new Dictionary<string, int>();
            var heroMp = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            int hpMax = 100;
            int mpMax = 200;

            for (int i = 0; i < n; i++)
            {
                string[] heros = Console.ReadLine()
                    .Split(" ");
                string heroName = heros[0];
                int hP = int.Parse(heros[1]);
                int mP = int.Parse(heros[2]);

                heroHp[heroName] = hP > hpMax ? hpMax : hP;
                heroMp[heroName] = mP > mpMax ? mpMax : mP;

            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArg = input.Split(" - ");
                string command = cmdArg[0];
                string heroName = cmdArg[1];

                if (command == "CastSpell")
                {
                    int mPNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];

                    if (heroMp[heroName] >= mPNeeded)
                    {
                        heroMp[heroName] -= mPNeeded;
                        Console.WriteLine($"{heroName} has successfully cast " +
                            $"{spellName} and now has {heroMp[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = Console.ReadLine();

                    heroHp[heroName] -= damage;
                    if (heroHp[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHp[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroHp.Remove(heroName);
                        heroMp.Remove(heroName);
                    }
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(cmdArg[2]);
                    int mPBefore = heroMp[heroName];
                    heroMp[heroName] += amount;

                    if (heroMp[heroName] > mpMax)
                    {
                        heroMp[heroName] = mpMax;

                    }
                    int mPAfter = heroMp[heroName];
                    int totalAmount = mPAfter - mPBefore;

                    Console.WriteLine($"{heroName} recharged for {totalAmount} MP!");

                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(cmdArg[2]);

                    int hPBefore = heroHp[heroName];
                    heroHp[heroName] += amount;

                    if (heroHp[heroName] > hpMax)
                    {
                        heroHp[heroName] = hpMax;
                    }

                    int hPAfter = heroHp[heroName];
                    int totalAmount = hPAfter - hPBefore;

                    Console.WriteLine($"{heroName} healed for {totalAmount} HP!");
                }



                input = Console.ReadLine();
            }
            foreach (var hero in heroHp.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"HP: {hero.Value}");
                Console.WriteLine($"MP: {heroMp[hero.Key]}");
            }
        }
    }
}
