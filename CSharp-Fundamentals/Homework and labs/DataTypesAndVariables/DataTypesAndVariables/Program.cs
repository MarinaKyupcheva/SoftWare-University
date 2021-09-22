using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = meters / 1000.00f;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
