using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamHomePrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendence = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int attendences = int.Parse(Console.ReadLine());

                double totalBonus = ((1.0 * attendences / countOfLectures) * (5 + initialBonus));

                if(maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendence = attendences;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendence} lectures.");
            
        }
    }
}
