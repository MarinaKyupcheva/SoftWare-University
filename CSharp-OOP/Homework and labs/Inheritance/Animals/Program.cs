using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string command = Console.ReadLine();
                string[] animals = Console.ReadLine().Split(" ").ToArray();
                string name = animals[0];
                int age = int.Parse(animals[1]);
                string gender = animals[2];

                if(command == "Beast!")
                {
                    break;
                }

                if (string.IsNullOrEmpty(name) || age < 0 || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;

                }


                if (command == "Cat")
            {
                var cat = new Cat(name, age, gender);
                Console.WriteLine(cat);
                Console.WriteLine(cat.ProduceSound());
            }

            else if (command == "Dog")
            {
                var dog = new Dog(name, age, gender);
                Console.WriteLine(dog);
                Console.WriteLine(dog.ProduceSound());
            }
            else if (command == "Frog")
            {
                var frog = new Frog(name, age, gender);
                Console.WriteLine(frog);
                Console.WriteLine(frog.ProduceSound());
            }
            else if (command == "Kittens")
            {
                var kittens = new Kittens(name, age, gender);
                Console.WriteLine(kittens);
                Console.WriteLine(kittens.ProduceSound());
            }
            else if (command == "TomCat")
            {
                var tomCat = new TomCat(name, age, gender);
                Console.WriteLine(tomCat);
                Console.WriteLine(tomCat.ProduceSound());
            }
           
            
        }


        }
    }
}
