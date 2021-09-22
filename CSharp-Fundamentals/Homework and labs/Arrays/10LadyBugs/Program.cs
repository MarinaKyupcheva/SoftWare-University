using System;
using System.Collections.Generic;
using System.Linq;

namespace _10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int [] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                if (indexes.Contains(i)) arr[i] = 1;
            }

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] cmdArg = input.Split(" ");
                int ladyBugIndex = int.Parse(cmdArg[0]);
                string direction = cmdArg[1];
                int flyLenght = int.Parse(cmdArg[2]);

                if ((ladyBugIndex >= 0) && (ladyBugIndex < size) && (arr[ladyBugIndex] == 1))
                {
                    arr[ladyBugIndex] = 0;

                    if (direction == "right")
                    {
                        while ((ladyBugIndex + flyLenght < size) && (ladyBugIndex + flyLenght >= 0))
                        {
                            if (arr[ladyBugIndex + flyLenght] == 0)
                            {
                                arr[ladyBugIndex + flyLenght] = 1;
                                break;
                            }
                            else ladyBugIndex += flyLenght;
                        }
                    }
                    else if (direction == "left")
                    {
                        while ((ladyBugIndex - flyLenght >= 0) && (ladyBugIndex - flyLenght < size))
                        {
                            if (arr[ladyBugIndex - flyLenght] == 0)
                            {
                                arr[ladyBugIndex - flyLenght] = 1;
                                break;
                            }
                            else ladyBugIndex -= flyLenght;
                        }
                    }
                    else arr[ladyBugIndex] = 1;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}