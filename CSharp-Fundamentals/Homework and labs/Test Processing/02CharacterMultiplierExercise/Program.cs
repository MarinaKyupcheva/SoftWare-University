using System;

namespace _02CharacterMultiplierExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(" ");

            var firstWord = words[0];
            var secondWord = words[1];

            var shortestWord = firstWord;
            var longestWord = secondWord;

            if(firstWord.Length > secondWord.Length)
            {
                shortestWord = secondWord;
                longestWord = firstWord;
            }
            var total = Multiplyed(longestWord, shortestWord);

            Console.WriteLine(total);
        }
        private static int Multiplyed(string longestWord, string shortestWord)
        {
            int sum = 0;
           
            for (int i = 0; i < shortestWord.Length; i++)
            {
                int multiplyed = shortestWord[i] * longestWord[i];
                sum += multiplyed;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }

            return sum;
        }
    }
}
