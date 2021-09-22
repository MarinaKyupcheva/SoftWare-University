using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList random = new RandomList();
            random.Add("Fifo");
            random.Add("Lifo");
            random.Add("Kiro");
            random.Add("Koko");
            random.Add("Pipi");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.RandomString());
            }

         
        }
    }
}
