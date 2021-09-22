using System;
using System.Linq;

namespace _02CommonElementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] firstArray = Console.ReadLine().Split(" ").ToArray();
            string[] secondArray = Console.ReadLine().Split(" ").ToArray();

            foreach (string element in secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (element == firstArray[i])
                    {
                        Console.Write(element + " ");
                    }
                    
                }
            }
        }
    }
}
