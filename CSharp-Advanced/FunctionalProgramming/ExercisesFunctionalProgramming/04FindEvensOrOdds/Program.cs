using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int first = array[0];
            int second = array[1];

            string command = Console.ReadLine();

            Func<int, int, List<int>> generateNumbers = (f, s) =>
            {
                List<int> numbers = new List<int>();

                for (int i = first; i <= second; i++)
                {
                    numbers.Add(i);
                }
                return numbers;
            };

            List<int> nums = generateNumbers(first, second);


            Predicate<int> predicate = n => true;

            if(command == "even")
            {
                predicate = n => n % 2 == 0;
            }
            else if(command == "odd")
            {
                predicate = n => n % 2 != 0;
            }

            //MyWhere(nums, n => n % 2 == 0);

            Console.WriteLine(string.Join(" ", MyWhere(nums, predicate)));
        }

        static List<int> MyWhere(List<int> nums, Predicate<int> predicate)
        {
            List<int> newList = new List<int>();

            foreach (var num in nums)
            {
                if (predicate(num))
                {
                    newList.Add(num);
                }
            }
            return newList;
        }
    }
}
