using System;

namespace _02PoundstoDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollar = double.Parse(Console.ReadLine());
            double britishPound = dollar * 1.31;
            Console.WriteLine($"{britishPound:f3}");

        }
    }
}
