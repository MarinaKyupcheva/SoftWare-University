using System;

namespace _09PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string input = " ";
            int remineder, sum = 0;
            int temp = number;

            while ((input = Console.ReadLine()) != "End")
            {


                while (number > 0)
                {

                    remineder = number % 10;
                   
                    sum = (sum * 10) + remineder;
                    
                    number = number / 10;
                }
                if (temp == sum)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                Console.ReadKey();
            }
        }
    }
}
