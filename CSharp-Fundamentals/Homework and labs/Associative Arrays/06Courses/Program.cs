using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArg = input.Split(" : ");
                string courseName = cmdArg[0];
                string studentName = cmdArg[1];

                if (!output.ContainsKey(courseName))
                {
                    output.Add(courseName, new List<string>());
                }
                output[courseName].Add(studentName);

               
 
                input = Console.ReadLine();
            }
            foreach (var item in output.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var kvp in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
            
        }
    }
}
