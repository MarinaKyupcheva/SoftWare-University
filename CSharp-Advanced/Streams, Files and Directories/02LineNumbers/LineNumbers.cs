using System;
using System.IO;
using System.Linq;

namespace _02LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int countOfLetters = CountOfLetters(line);
                int countOfMarks = CountOfMarks(line);

                result[i] = $"Line {i + 1}: {lines[i]}({countOfLetters})({countOfMarks})";
            }

            File.WriteAllLines("../../../output.txt", result);
        }

        static int CountOfLetters (string line)
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char letter = line[i];

                if (Char.IsLetter(letter))
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CountOfMarks(string line)
        {
            char[] punctuationalMarks = { ',', '?', '\'', ';', ':', '!', '.','-' };
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char marks = line[i];

                if (punctuationalMarks.Contains(marks))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
