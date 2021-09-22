using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Foods;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }

                string[] animalParts = command.Split(" ");
                Animal animal = CreateAnimal(animalParts);
                
                animals.Add(animal);

                string[] foodParts = Console.ReadLine().Split();
                

                Food food = CreateFood(foodParts);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] foodParts)
        {
            string typeOfFood = foodParts[0];
            int quantity = int.Parse(foodParts[1]);

            Food food = null;

            if(typeOfFood == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (typeOfFood == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (typeOfFood == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (typeOfFood == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }
            return food;
        }

        private static Animal CreateAnimal(string[] animalParts)
        {
            
            string type = animalParts[0];
            string name = animalParts[1];
            double weight = double.Parse(animalParts[2]);


            Animal animal = null;

            if(type == nameof(Hen))
            {
                animal = new Hen(name, weight, double.Parse(animalParts[3]));
            }
            else if(type == nameof(Owl))
            {
                animal = new Owl(name, weight, double.Parse(animalParts[3]));
            }
            else if(type == nameof(Cat))
            {
                animal = new Cat(name, weight, animalParts[3], animalParts[4]);
               
            }
            else if(type == nameof(Dog))
            {
                animal = new Dog(name, weight, animalParts[3]);
            }
            else if(type == nameof(Mouse))
            {
                animal = new Mouse(name, weight, animalParts[3]);
            }
            else if(type == nameof(Tiger))
            {
                animal = new Tiger(name, weight, animalParts[3], animalParts[4]);
            }
            return animal;
        }
    }
}
