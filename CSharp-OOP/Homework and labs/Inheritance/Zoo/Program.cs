using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Henry");

            Console.WriteLine(animal.Name);
        }
    }
}
