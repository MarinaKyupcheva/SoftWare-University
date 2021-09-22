using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] givenCommand = command.Split();

                if (givenCommand[0] == "Add")
                {
                    wagons.Add(int.Parse(givenCommand[1]));
                }
                else
                {
                    int passengers = int.Parse(givenCommand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        
                        bool isEnoughtCapasity = wagons[i] + passengers <= maxCapacity;
                        if (isEnoughtCapasity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();

            }
            
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
