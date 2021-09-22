using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listsOfInteger = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] currentCommand = command.Split();
                int element = int.Parse(currentCommand[1]);
                string firstCommand = currentCommand[0];

                if (firstCommand == "Delete")
                {
                    listsOfInteger.RemoveAll(n => n == element);
                }
                else if (firstCommand == "Insert")
                {
                    
                    int index = int.Parse(currentCommand[2]);
                    listsOfInteger.Insert(index, element);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listsOfInteger));
        }
    }
}
