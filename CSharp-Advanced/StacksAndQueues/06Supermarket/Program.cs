using System;
using System.Collections.Generic;

namespace _06Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> clientsList = new Queue<string>();

            while(input != "End")
            {
               

                if (input == "Paid")
                {
                    while(clientsList.Count > 0)
                    {
                       
                        Console.WriteLine(clientsList.Dequeue());
                    }
                 
                    
                }
                else
                {
                    clientsList.Enqueue(input);
                }
               
               

                input = Console.ReadLine();
            }
            Console.WriteLine($"{clientsList.Count} people remaining.");
        }
    }
}
