using System;
using System.Collections.Generic;
using System.Linq;


namespace _01CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            Dictionary <char, int> words = new Dictionary <char, int>();

            foreach (var item in chars)
            {
                if (item != ' ')
                {
                    if (!words.ContainsKey(item))
                    {
                        words.Add(item, 0);
                    }
                    words[item]++;
                }
                
            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
