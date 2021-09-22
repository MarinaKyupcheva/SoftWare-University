using System;
using System.Collections.Generic;

namespace _03SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> result = new Stack<string>(new Stack<string>(input));

            while(result.Count > 1)
            {
                int leftNumber = int.Parse(result.Pop());
                string sign = result.Pop();
                int rightNumber = int.Parse(result.Pop());

                if(sign == "+")
                {
                    result.Push((leftNumber + rightNumber).ToString());
                }
                else if(sign == "-")
                {
                    result.Push((leftNumber - rightNumber).ToString());
                }
                
            }

            Console.WriteLine(result.Pop());
        }
    }
}
