using System;
using System.Linq;

namespace _06EqualSumsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound = true;

            for (int current = 0; current < array.Length; current++)
            {
                int sumRight = 0;

                for (int i = current + 1; i < array.Length; i++)
                {
                    sumRight += array[i];
                }
                int sumLeft = 0;

                for (int i = current - 1; i >= 0; i--)
                {
                    sumLeft += array[i];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(current + " ");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
