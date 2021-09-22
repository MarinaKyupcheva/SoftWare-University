using System;
using System.Linq;

namespace ObjectAndClassess
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = Console.ReadLine().Split(" ").ToArray();

            Random rnd = new Random();

            for (int i = 0; i <= words.Length - 1; i++)
            {
                int index = rnd.Next(0, words.Length - 1);
                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;

            }
            foreach (var temp in words)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
