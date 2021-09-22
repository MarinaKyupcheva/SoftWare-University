using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SugarCubesMidExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input;

            while((input = Console.ReadLine()) != "Mort")
            {
                string [] cmdArg = input.Split(" ");
                string command = cmdArg[0];
                

                if (command == "Add")
                {
                    int value = int.Parse(cmdArg[1]);
                  
                    list.Add(value);
                }

                else if (command == "Remove")
                {
                    int value = int.Parse(cmdArg[1]);
                    
                    if (list.Contains(value))
                    {
                        list.Remove(value);
                    }
                    
                }
                else if (command == "Replace")
                {
                    int value = int.Parse(cmdArg[1]);
                    int replacement = int.Parse(cmdArg[2]);
                    int index = list.FindIndex(x => x == value);
                    list[index] = replacement;
                }
                else if (command == "Collapse")
                {
                    int value = int.Parse(cmdArg[1]);
             

                    list.RemoveAll(x => x < value);

                }



            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
