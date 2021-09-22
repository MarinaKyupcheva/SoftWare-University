using System;

namespace _04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in banedWords)
            {
                string replacedWords = new string('*', word.Length);

                text = text.Replace(word, replacedWords);
            }
            Console.WriteLine(text);
        }
    }
}
