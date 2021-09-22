using System;
using System.Collections.Generic;
using System.Linq;

namespace _03InventoryList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] cmdArg = input.Split(" - ");
                string command = cmdArg[0];
                string item = cmdArg[1];
                

                if (command == "Collect")
                {
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }

                }
                else if (command == "Drop")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }

                }
                else if (command == "Combine Items")
                {
                    string[] tokens = item.Split(":");
                    string oldItem = tokens[0];
                    string newItem = tokens[1];

                    if (items.Contains(oldItem))
                    {
                        int index = items.IndexOf(oldItem);
                        if(index >= 0)
                        {
                            items.Insert(index + 1, newItem);
                        }
                        

                    }
                }
                else if (command == "Renew")
                {
                    if (items.Contains(item))
                    {
                        int index = items.FindIndex(x => x == item);

                        items.RemoveAt(index);
                        items.Add(item);
                    }
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
