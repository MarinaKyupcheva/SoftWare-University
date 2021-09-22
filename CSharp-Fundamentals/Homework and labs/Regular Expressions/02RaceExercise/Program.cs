using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02RaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participant = Console.ReadLine().Split(", ");

            Dictionary<string, int> names = new Dictionary<string, int>();

            foreach (var name in participant)
            {
                names.Add(name, 0);
            }

            string namePattern = @"[\W\d]";
            string distancePattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, distancePattern, "");

                int sum = 0;

                foreach (var digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;

                }
                if (names.ContainsKey(name))
                {
                    names[name] += sum;
                }


                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var kvp in names.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{text} place: {kvp.Key}");
                if(count == 4)
                {
                    break;
                }
            }
            
        }
    }
}
