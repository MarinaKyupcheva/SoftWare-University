using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace SetsAndDictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> times = new Dictionary<double, int>();

            

            for (int i = 0; i < input.Length; i++)
            {
                if (!times.ContainsKey(input[i]))
                {
                    times.Add(input[i], 0);
                }
                times[input[i]]++;
            }

            foreach (var time in times)
            {
                Console.WriteLine($"{time.Key} - {time.Value} times");
            }
        }
    }
}
