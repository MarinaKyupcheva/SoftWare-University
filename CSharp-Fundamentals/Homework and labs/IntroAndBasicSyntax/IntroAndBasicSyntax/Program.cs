using System;

namespace IntroAndBasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double Grade = double.Parse(Console.ReadLine());

           

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {Grade:f2}");
        }
    }
}
