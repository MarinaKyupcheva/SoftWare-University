using System;

namespace _01SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            int hours = 0;
            while (studentsCount > 0)
            {
                studentsCount -= sum;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }


            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
