using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> oddWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (oddWords.ContainsKey(wordInLowerCase))
                {
                    oddWords[wordInLowerCase]++;
                }
                else
                {
                    oddWords.Add(wordInLowerCase, 1);
                }
            }
            foreach (var count in oddWords)
            {
                if(!(count.Value % 2 == 0))
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
