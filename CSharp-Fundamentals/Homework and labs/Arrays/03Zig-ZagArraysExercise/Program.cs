using System;
using System.Linq;

namespace _03Zig_ZagArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArray = new string [n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                
                string [] currentArray = Console.ReadLine().Split().ToArray();
                string firstNumber = currentArray[0];
                string secondNumber = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;

                }
                else if (i % 2 == 1)
                {
                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
