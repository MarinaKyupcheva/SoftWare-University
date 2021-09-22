using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SugarCubesMidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] list = Console.ReadLine().Split(" ").ToArray();

            string input = Console.ReadLine();

            while(input != "Mort")
            {
                string [] cmdArg = input.Split(" ");
                string command = cmdArg[0];
                int value = int.Parse(cmdArg[1]);
                string replacement = cmdArg[2];

                if (command == "Add")
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        string index = list[list.Length - 1];
                        list[i] += value;
                    }
                    

                }
                else if (command == "Remove")
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        if(i == value)
                        {
                            string index = list[i];
                            
                        }
                    }

                }
                else if (command == "Replace")
                {
                    

                }
                else if (command == "Collapse")
                {
                    
                }




                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
