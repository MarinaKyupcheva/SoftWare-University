using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;


            for (int i = 0; i < number.Length; i++)
            {
                int evenNumber = number[i];
                int oddNumber = number[i];

                if(evenNumber%2 == 0)
                {
                    evenSum += evenNumber;
                }
                else
                {
                    oddSum += oddNumber;
                }
                
            }
            int difference = evenSum - oddSum;
            Console.WriteLine(difference);
        }
    }
}
