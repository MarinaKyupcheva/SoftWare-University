using System;

namespace _12EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = int.Parse(Console.ReadLine());
           
            

            if (evenNumber % 2 == 0)
            {
                Console.WriteLine($"The number is: {evenNumber}");
            }
            else

    {
                Console.WriteLine("Please write an even number.");
            }
        }
    }
}
