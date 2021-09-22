using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02EmojiDetectorStamo
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternDigits = @"\d";
            string patternEmojis = @"(\:{2}|\*{2})[A-Z][a-z]{2,}\1";

            string input = Console.ReadLine();
            Regex digitReg = new Regex(patternDigits);
            Regex emojiReg = new Regex(patternEmojis);

            long coolThreshold = 1;
            digitReg.Matches(input).Select(x => x.Value).Select(int.Parse).ToList()
                .ForEach(x => coolThreshold *= x);

            var matches = emojiReg.Matches(input);
            int totalEmojis = matches.Count;
            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in matches)
            {
                long coolIndex = emoji.Value.Substring(2, emoji.Value.Length - 4)
                    .ToCharArray().Sum(x => (int)x);

                if(coolIndex > coolThreshold)
                {
                    coolEmojis.Add(emoji.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");
            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }

            }
            
        }
    }

