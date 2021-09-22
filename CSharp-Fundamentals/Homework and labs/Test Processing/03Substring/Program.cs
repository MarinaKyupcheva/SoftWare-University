using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string secondWord = Console.ReadLine();

            int index = secondWord.IndexOf(word);

            while(index != -1)
            {
                secondWord = secondWord.Remove(index, word.Length);

                index = secondWord.IndexOf(word);
            }
            Console.WriteLine(secondWord);
        }
    }
}
