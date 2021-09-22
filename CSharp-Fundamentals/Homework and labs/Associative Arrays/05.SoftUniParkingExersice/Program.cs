using System;
using System.Collections.Generic;

namespace _05.SoftUniParkingExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> output = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string task = command[0];
                string userName = command[1];

                if (task == "register")
                {
                    string licensePlateNumber = command[2];

                    if (output.ContainsKey(userName))
                    {
                        
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        output.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }

                }
                else if (task == "unregister")
                {
                    if (output.ContainsKey(userName))
                    {
                        output.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                        
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
                    
            }
            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
