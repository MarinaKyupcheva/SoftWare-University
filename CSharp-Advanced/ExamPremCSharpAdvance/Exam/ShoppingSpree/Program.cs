using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();
        
            try
            {
                 people = ReadPeople();
                products = ReadProduct();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {
                var command = Console.ReadLine();

                if(command == "END")
                {
                    break;
                }

                var parts = command.Split(" ");
                var name = parts[0];
                var product = parts[1];

                var person = people[name];
                var productt = products[product];

                try
                {
                    person.AddProduct(productt);
                    Console.WriteLine($"{name} bought {product}");
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }

        private static Dictionary<string, Product> ReadProduct()
        {
            var names = new Dictionary<string, Product>();
            var cmd = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in cmd)
            {
                var cmdArgs = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = cmdArgs[0];
                var cost = decimal.Parse(cmdArgs[1]);
                names[name] = new Product(name, cost);
            }
                return names;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            var result = new Dictionary<string, Person>();

            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var personData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = personData[0];
                var money = decimal.Parse(personData[1]);

                result[name] = new Person(name, money);
            }

            return result;
        }
    }
}
