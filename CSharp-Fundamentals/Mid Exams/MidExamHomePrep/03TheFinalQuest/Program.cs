using System;
using System.Collections.Generic;
using System.Linq;

namespace _03TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> message = Console.ReadLine()
                .Split(" ")
                .ToList();
            string input = Console.ReadLine();
           

            while(input != "Stop")
            {
                string[] cmdArg = input.Split(" ");
                string command = cmdArg[0];

                if(command == "Delete")
                {
                    int index = int.Parse(cmdArg[1]) + 1;
                    if (index >= 0 && index < message.Count)
                    {
                        message.RemoveAt(index);
                    }
                }
                else if(command == "Swap")
                {
                    string firstWord = cmdArg[1];
                    string secondWord = cmdArg[2];
                    
                    if(message.Contains(firstWord) && message.Contains(secondWord))
                    {
                        int index1 = message.FindIndex(x => x == firstWord);
                        int index2 = message.FindIndex(x => x == secondWord);

                        message[index1] = secondWord;
                        message[index2] = firstWord;
                    }
                }

                else if(command == "Put")
                {
                    string word = cmdArg[1];
                    int index = int.Parse(cmdArg[2]) - 1;
                    if (index >= 0 && index <= message.Count)
                    {
                        message.Insert(index, word);
                    }
                }
                

                else if (command == "Sort")
                {
                    message.Sort();
                    message.Reverse();
                }
        
                else if (command == "Replace")
                {
                    string firstWord = cmdArg[1];
                    string secondWord = cmdArg[2];
                    if (message.Contains(secondWord))
                    {

                        
                        int index2 = message.FindIndex(x => x == secondWord);

                       
                        message[index2] = firstWord;
                    }
                }
                input = Console.ReadLine();
        
          }
            Console.WriteLine(string.Join(" ", message));
        }
    }
}
