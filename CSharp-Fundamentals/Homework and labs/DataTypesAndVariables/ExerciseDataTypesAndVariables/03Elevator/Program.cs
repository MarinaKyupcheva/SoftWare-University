using System;

namespace _03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capasity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(numberOfPeople / (double)capasity);

            Console.WriteLine(courses);
        }
    }
}
