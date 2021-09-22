using System;
using System.Linq;

namespace _06MaxSequenceofEqualElementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestCounter = 0;
            int bestIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int firstNumber = array[i];
                int counter = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (firstNumber == array[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write(array[bestIndex] + " ");
            }
        }
    }
}
