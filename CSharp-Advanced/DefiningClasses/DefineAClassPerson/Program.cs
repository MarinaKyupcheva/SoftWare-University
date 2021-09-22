using DefineAClassPerson;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split(" ");
                string name = cmd[0];
                int age = int.Parse(cmd[1]);

                Person currPerson = new Person(name, age);
                people.Add(currPerson);


            }

            List<Person> filteredPerson = people.Where(p => p.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (Person item in filteredPerson)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
           
        }
    }
}
