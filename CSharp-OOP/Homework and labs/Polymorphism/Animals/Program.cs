using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Gosho", "Meat");
            Animal cat = new Cat("Pesho", "Whiscas");

            Console.WriteLine(dog.ExplainSelf());
            Console.WriteLine(cat.ExplainSelf());
        }
    }
}
