using System;
using System.Linq;

namespace _04ReverseArrayOfStringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] array = Console.ReadLine().Split(" ");

            int n = int.Parse (Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentElement = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    string elementToRotate = array[j];
                    array[j - 1] = elementToRotate;
                }
                array[array.Length - 1] = currentElement;
            }
            Console.WriteLine(string.Join (" ", array));
        }
    }
}
