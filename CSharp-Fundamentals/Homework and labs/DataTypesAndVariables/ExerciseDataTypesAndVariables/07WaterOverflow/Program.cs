using System;

namespace _07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            short sum = 0;
            for (int i = 0; i < n; i++)
            {
                short litters = short.Parse(Console.ReadLine());
                
                

                if (sum + litters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += litters;
                    
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
