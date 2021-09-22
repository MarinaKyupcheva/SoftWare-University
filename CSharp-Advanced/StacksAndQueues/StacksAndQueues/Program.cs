using System;
using System.Collections;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversedString = new Stack<char>();

            for (int i = 0; i <input.Length; i++)
            {
                reversedString.Push(input[i]);

            }
            while (reversedString.Count > 0)
            {
                Console.Write(reversedString.Pop());
            }
        }
    }
}
