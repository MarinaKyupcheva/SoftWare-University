using System;
using System.Collections.Generic;
using System.Linq;

namespace _02StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> summed = new Stack<int>(numbers);
            string input = Console.ReadLine().ToLower();

            while(input != "end")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];
                

                if(command == "add")
                {

                    summed.Push(int.Parse(cmdArg[1]));
                    summed.Push(int.Parse(cmdArg[2]));



                }

                else if (command == "remove")
                {
                    int count = int.Parse(cmdArg[1]);
                    
                    if(count <= summed.Count)

                    for (int i = 0; i < count; i++)
                    {
                            summed.Pop();
                    }

                }





                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: " + summed.Sum());

        }
    }
}
