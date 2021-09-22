using System;

namespace _07StringExplosionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if(currentChar == '>')
                {
                    bomb += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if(bomb > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
