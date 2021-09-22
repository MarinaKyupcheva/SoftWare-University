using System;
using System.Linq;

namespace _08MagicSumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int firstNumber = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNumber = array[j];

                    if (firstNumber + secondNumber == number)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber}");
                        break;
                    }
                }
            }
        }
    }
}
