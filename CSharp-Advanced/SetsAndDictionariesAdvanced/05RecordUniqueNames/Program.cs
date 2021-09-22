using System;
using System.Collections.Generic;

namespace _05RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> students = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                students.Add(input);
            }
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
