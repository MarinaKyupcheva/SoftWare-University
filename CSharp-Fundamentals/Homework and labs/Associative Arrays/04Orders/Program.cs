using System;
using System.Collections.Generic;

namespace _04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] orders = command.Split(" ");
                string productName = orders[0];
                double price = double.Parse(orders[1]);
                double quantity = double.Parse(orders[2]);

                if (!output.ContainsKey(productName))
                {
                    output.Add(productName, new List<double> { price, quantity });
                }
                else
                {
                    output[productName][0] = price;
                    output[productName][1] += quantity;
                }
                

               command = Console.ReadLine();
            }
            foreach (var kvp in output)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
