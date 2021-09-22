using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmailsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";
            
            var input = Console.ReadLine();

            MatchCollection matchedMails = Regex.Matches(input, pattern);

            foreach (Match meil in matchedMails)
            {
                Console.WriteLine(meil);
            }
        }
    }
}
