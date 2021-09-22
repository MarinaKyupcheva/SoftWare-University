using System;
using System.Collections;
using System.Collections.Generic;

namespace _04MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> result = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {

                if(input[i] == '(')
                {
                   result.Push(i);
                }

                if(input[i] == ')')
                {
                    int startIndex = result.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex +1));
                }
            }

        }
    }
}
