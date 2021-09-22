using System;
using System.Linq;

namespace _01ValidUsernamesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = Console.ReadLine().Split(", ");

            for (int i = 0; i < userName.Length; i++)
            {
                var curr = userName[i];

                if (IsValid(curr))
                {
                    Console.WriteLine(curr);
                }
            }
        }
        private static bool IsValid(string current)
        {
            return current.Length >= 3 &&
                current.Length <= 16 &&
                current.All(x => char.IsLetterOrDigit(x)) ||
                current.Contains("-") ||
                current.Contains("_");

            
        }
    }
}
