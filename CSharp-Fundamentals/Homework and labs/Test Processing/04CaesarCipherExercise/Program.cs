using System;

namespace _04CaesarCipherExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach (char item in input)
            {
                var result = (char)(item + 3);
                Console.Write(result);
            }
            
        }
    }
}
