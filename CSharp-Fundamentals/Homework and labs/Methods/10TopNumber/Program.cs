using System;

namespace _10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string currentNumber = i.ToString();
                bool isOdd = false;
                int sumOfDigit = 0;

                foreach (int curr in currentNumber)
                {
                    int parseNumber = (int)curr;

                    if (parseNumber % 2 == 1)
                    {
                       isOdd = true;
                    }
                    sumOfDigit += parseNumber;
                }

               if(sumOfDigit % 8 == 0 && isOdd == true)
                {
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
