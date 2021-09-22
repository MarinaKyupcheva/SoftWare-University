using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" ");

                if(cmdArgs[0] == "Add")
                {
                    numbers.Add(int.Parse(cmdArgs[1]));
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    

                    if (IsValidindex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (cmdArgs[0] == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if(IsValidindex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (cmdArgs[0] == "Shift")
                {
                    int rotation = int.Parse(cmdArgs[2]);

                    if(cmdArgs[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElement = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                                
                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }
                    }
                    else if (cmdArgs[1] == "right")
                            
                            
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastElement;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static bool IsValidindex(int index, int count)
        {
            return index < 0 || index > count; 
        }
    }
}
