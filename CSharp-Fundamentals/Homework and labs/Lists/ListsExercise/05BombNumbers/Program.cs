using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int [] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = arr[0];
            int bombPower = arr[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentnumber = numbers[i];

                if (currentnumber == bombNumber)
                {
                    int startIndex = i - bombPower;
                    int endIndex = i + bombPower;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToRemove);

                    i = startIndex - 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
