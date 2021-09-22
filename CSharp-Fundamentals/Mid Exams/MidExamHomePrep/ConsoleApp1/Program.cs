using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];
                string item = cmdArg[1];

                if(command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string newItem = cmdArg[2];
                    if (groceries.Contains(item))
                    {
                        int index = groceries.FindIndex(x => x == item);
                        groceries[index] = newItem;
                    }

                }
                else if(command == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        int index = groceries.FindIndex(x => x == item);
                        groceries.RemoveAt(index);
                        groceries.Add(item);
                    }
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
        
    

