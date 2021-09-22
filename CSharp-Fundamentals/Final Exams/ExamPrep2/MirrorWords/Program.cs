using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExamPrep2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\#?|\@?)(?<wordone>[\w]{3,})(\#{2}?|\@{2}?)(?<wordtwo>[\w]{3,})\1";

            List<string> mirrorWords = new List<string>();
            int matchCounter = 0;

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string firstWord = match.Groups["wordone"].Value;
                    string secondWord = match.Groups["wordtwo"].Value;
                    char[] secondChar = secondWord.ToCharArray();
                    Array.Reverse(secondChar);
                    string secondReversed = new string(secondChar);

                    if(firstWord == secondReversed)
                    {
                        string miror = firstWord + " <=> " + secondWord;
                        mirrorWords.Add(miror);
                    }
                    matchCounter++;

                }

            }
            if(matches.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matchCounter} word pairs found!");
            }
            if(mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
