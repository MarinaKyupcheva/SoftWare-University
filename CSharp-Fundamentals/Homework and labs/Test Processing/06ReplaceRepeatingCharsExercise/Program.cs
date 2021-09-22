using System;
using System.Text;

namespace _06ReplaceRepeatingCharsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            var sequence = Console.ReadLine().ToCharArray();

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if(sequence[i] != sequence[i + 1])
                {
                    sb.Append(sequence[i]);

                }
            }
            var symbol = sequence[sequence.Length - 1];
            sb.Append(symbol);
            Console.WriteLine(sb.ToString());
        }
    }
}
