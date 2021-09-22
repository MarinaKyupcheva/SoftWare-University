using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string expectedResultPath = Path.Combine("..", "..", "..", "actualResults.txt");
            string[] words = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordsCounts = new Dictionary<string, int>();
            

            foreach (var word in words)
            {
               
                    wordsCounts.Add(word.ToLower(), 0);
                
            }

            string text = File.ReadAllText("../../../text.txt").ToLower();

            string[] wordsInText = text.Split(new string[] { " ", ", ", "! ", "? ", "-", ".", Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in wordsInText)
            {
                if (wordsCounts.ContainsKey(word))
                {
                    wordsCounts[word]++;
                }
            }

            Dictionary<string, int> sortedWords = wordsCounts
                .OrderByDescending(v => v.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
               

            List<string> outputLines = sortedWords
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToList();

            File.WriteAllLines(expectedResultPath, outputLines);
        }
    }
}
