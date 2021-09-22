using System;
using System.Linq;

namespace _03CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> printSmallestNumber = n =>
            {
                int minNum = int.MaxValue;
                foreach (var num in n)
                {
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                   
                }
                return minNum;
            };
            Console.WriteLine(printSmallestNumber(numbers));
           



            


        }
    }
}
