using System;
using System.Collections.Generic;

namespace _03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> List = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split();
                string guestName = command[0];

                if(command.Length > 3)
                {
                    if (List.Contains(guestName))
                    {
                        List.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
                else
                {
                    if (!List.Contains(guestName))
                    {
                        List.Add(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                }
                   
            }
            Console.WriteLine(string.Join(Environment.NewLine, List));
        }
    }
}
