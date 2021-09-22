using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            var phones = Console.ReadLine();

            MatchCollection match = Regex.Matches(phones, pattern);
            List<string> phoneList = new List<string>();

            foreach (Match phone in match)
            {
                phoneList.Add(phone.ToString());
               
            }
            Console.WriteLine(string.Join (", ", phoneList));
        }
    }
}
