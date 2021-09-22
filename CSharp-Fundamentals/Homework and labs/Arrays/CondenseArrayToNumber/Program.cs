using System;
using System.Globalization;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int [] condensed = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > 1)
                {
                    condensed[i] = numbers.Length - 1;

                    condensed[i] = numbers[i] + numbers[i + 1];
                    condensed[i] = numbers[i];
                    Console.WriteLine(condensed);
                }
                else
                {
                    Console.WriteLine(numbers);
                }
            }
        }
    }
}
