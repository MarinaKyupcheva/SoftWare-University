using System;
using System.Collections.Generic;
using System.Linq;

namespace _10PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ").ToList();

            string command = Console.ReadLine();

           

            while (command != "Party!")
            {
                string[] input = command.Split(" ");
                string cmd = input[0];
                string secondPartOfCmd = input[1];
                string lastPart = input[2];

                var predicate = GetPredicate(secondPartOfCmd, lastPart);

                if (cmd == "Remove")
                {
                    people.RemoveAll(predicate);
                }
                else if (cmd == "Double")
                {
                    var matches = people.FindAll(predicate);
                    if (matches.Count > 0)
                    {
                        var index = people.FindIndex(predicate);
                        people.InsertRange(index, matches);
                    }
                }

                command = Console.ReadLine();
            }
            if (people.Count != 0)
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> GetPredicate(string commandType, string arg)
        {
            if(commandType == "StartsWith")
            {
                return name => name.StartsWith(arg);

            }
            else if(commandType == "EndsWith")
            {
                return name => name.EndsWith(arg);
            }
            else if(commandType == "Length")
            {
                return name => name.Length == int.Parse(arg);
            }
            else
            {
               throw new ArgumentException("Invalid command type: " + commandType);
            }
        }
    }
}
