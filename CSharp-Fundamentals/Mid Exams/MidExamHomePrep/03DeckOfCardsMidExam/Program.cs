using System;
using System.Collections.Generic;
using System.Linq;

namespace _03DeckOfCardsMidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(", ");
                string command = cmdArg[0];
                

                if(command == "Add")
                {
                    string cardName = cmdArg[1];
                    if (list.Contains(cardName))
                    {
                        Console.WriteLine("Card is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Card successfully bought");
                        list.Add(cardName);
                    }


                }

                else if (command == "Remove")
                {
                    string cardName = cmdArg[1];
                    if (list.Contains(cardName))
                    {
                        Console.WriteLine("Card successfully sold");
                        list.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }

                else if (command == "Remove At")
                {
                    int index = int.Parse(cmdArg[1]);
                    if(!(index > 0 && index <= list.Count))
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        list.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                }

                else if(command == "Insert")
                {
                    int index = int.Parse(cmdArg[1]);
                    string cardName = cmdArg[2];

                    if(!(index > 0 && index <= list.Count) && list.Contains(cardName))
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (index > 0 && index <= list.Count && !(list.Contains(cardName)))
                    {
                        list.Insert(index, cardName);
                        Console.WriteLine("Card successfully bought");
                    }
                    else if (index > 0 && index <= list.Count && list.Contains(cardName))
                    {
                        Console.WriteLine("Card is already bought");
                    }
                }


            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
