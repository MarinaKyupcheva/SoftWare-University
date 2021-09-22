using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] cmdArg = input.Split(" ");
                string command = cmdArg[0];
                

                if (command == "swap")
                {
                    
                    
                    
                }

                else if (command == "multiply")
                {
                //    int firstIndex = int.Parse(cmdArg[1]);
                //    int secondIndex = int.Parse(cmdArg[2]);
                //    elements[firstIndex] *= elements[secondIndex];
                    


                }

                else if (command == "decrease")
                {
                //   for (int i = 0; i < elements.Length; i--)
                //   {
                //
                //   }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
   
