using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArg = input.Split(" ");
                string command = cmdArg[0];
                int index = int.Parse(cmdArg[1]);
                int value = int.Parse(cmdArg[2]);

                if(command == "Shoot")
                {
                    if (!(index < 0 || index >= targets.Count))
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                    
                }

                else if(command == "Add")
                {
                    if (!(index < 0 || index >= targets.Count))
                    {
                        targets.Insert(index, value);


                    }
                    else
                    {


                        Console.WriteLine($"Invalid placement!");
                    }
                }   

                else if (command == "Strike")
                {
                   if (!(index - value < 0 || index + value >= targets.Count))
                   {
                        targets.RemoveRange(index - value, (value * 2) +1) ;

                   }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                    
                    
                }




                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
