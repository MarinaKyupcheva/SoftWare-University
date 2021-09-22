using System;
using System.Text.RegularExpressions;

namespace _02AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\#?|\|?)(?<name>[A-Za-z\s]+)(\1)(?<date>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>[0-9]+)(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);

            int totalCalories = 0;

            foreach (Match match in matches)
            {
                int calories = (int.Parse)(match.Groups["calories"].Value);
                totalCalories += calories;
            }
            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}," +
                    $" Nutrition: {match.Groups["calories"].Value}");
            }

        }
    }
}
