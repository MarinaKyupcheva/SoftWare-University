using System;

namespace _01PiratesMidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunderForDay = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder+=plunderForDay;

                if(i % 3 == 0)
                {
                    totalPlunder += plunderForDay * 0.5;
                }

                if (i % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }
            }

            if(totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                double percentage = 0;
                percentage = totalPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
