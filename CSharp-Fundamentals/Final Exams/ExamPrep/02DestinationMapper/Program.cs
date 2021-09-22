using System;
using System.Text.RegularExpressions;

namespace _02DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=?|\/?)(?<location>[A-Z]{1,}[a-z]+)(\1)";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            
            foreach (Match destination in matches)
            {
                count += destination.Groups["location"].Length;

                Console.Write($"Destinations: {destination.Groups["location"] + ", ");
                Console.WriteLine($"Travel Points: {count}");
            }
        }
    }
}
