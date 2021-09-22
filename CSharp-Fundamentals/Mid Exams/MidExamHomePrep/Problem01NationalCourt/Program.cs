using System;

namespace Problem01NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int totalPeopleCount = int.Parse(Console.ReadLine());

            int sum = firstEmployee + secondEmployee + thirdEmployee;
            int hours = 0;

            while (totalPeopleCount > 0)
            {
                totalPeopleCount -= sum;
                hours++;

                if(hours % 4 == 0)
                {
                    hours++;
                }

                
            }

            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
