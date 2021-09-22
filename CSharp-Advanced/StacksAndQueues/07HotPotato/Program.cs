using System;
using System.Collections.Generic;

namespace _07HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());

            Queue<string> potatoQueue = new Queue<string>(names);

            int potatoToses = 0;

           while(potatoQueue.Count > 1)
            {
                potatoToses++;

                string kid = potatoQueue.Dequeue();
                if(potatoToses == number)
                {
                    potatoToses = 0;
                    Console.WriteLine("Removed " + kid);
                }

                else
                {
                    potatoQueue.Enqueue(kid);
                }
            }
            Console.WriteLine("Last is " + potatoQueue.Dequeue());

        }
    }
}
