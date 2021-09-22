
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> birthablesByName = new Dictionary<string, IBuyer>();
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(" ");
                if (parts.Length == 4)
                {

                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    string birthdate = parts[3];
                    birthablesByName[name] = new Citizen(name, age, id, birthdate);

                }
                else
                {

                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string group = parts[2];
                    birthablesByName[name] = new Rebel(name, age, group);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();

                if(name == "End")
                {
                    break;
                }

                if (!birthablesByName.ContainsKey(name))
                {
                    continue;
                }

                IBuyer buyer = birthablesByName[name];

                buyer.BuyFood();

                
            }

            var total = birthablesByName.Values.Sum(x => x.Food);
            Console.WriteLine(total);
        }
          
    }
}
