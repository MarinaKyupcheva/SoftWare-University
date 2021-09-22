using System;
using System.Linq;

namespace _03CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Func<string, bool> checker = x => x[0] == x.ToUpper()[0];

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checker).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
