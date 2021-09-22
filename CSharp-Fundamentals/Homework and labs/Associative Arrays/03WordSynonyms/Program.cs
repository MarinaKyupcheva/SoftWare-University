using System;
using System.Collections.Generic;

namespace _03WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dictionari = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (dictionari.ContainsKey(word))
                {
                    dictionari[word].Add(synonym);
                }
                else
                {
                    dictionari.Add(word, new List<string>() { synonym });
                }
            }
            foreach (var word in dictionari)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
