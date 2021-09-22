﻿using System;
using System.Text.RegularExpressions;

namespace _02ProblemExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (!match.Success)
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
                string numbers = match.Groups[2].Value;
                string lowerLetters = match.Groups[3].Value;
                string upperLetters = match.Groups[4].Value;
                string symbols = match.Groups[5].Value;

                string encryptedPasword = string.Concat(numbers, lowerLetters, upperLetters, symbols);
                Console.WriteLine($"Password: {encryptedPasword}");
            }
           

            

        }
    }
}
