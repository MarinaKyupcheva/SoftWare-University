using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if(currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'u')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if(currentChar == 'y')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
