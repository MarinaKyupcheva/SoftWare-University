using System;
using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+[' '][A-Z][a-z]+\b";

            string names = Console.ReadLine();
            MatchCollection nameMatches = Regex.Matches (names, regex);

            foreach (Match name in nameMatches)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
