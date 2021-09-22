using System;

namespace _06ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstchar = char.Parse(Console.ReadLine());
            char secondchar = char.Parse(Console.ReadLine());
            char thirdchar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdchar} {secondchar} {firstchar}");
        }
    }
}
