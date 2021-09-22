using System;
using System.Collections;
using System.Linq;

namespace ExamPreparationAdvansed
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inpuLilies = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] inputRoses = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Stack lilies = new Stack(inpuLilies);
            Queue roses = new Queue(inputRoses);

            int sum = 0;
            int wreath = 0;
            int flowersForLater = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int lilie = (int)lilies.Pop();
                int rose = (int)roses.Dequeue();

               
                while (true)
                {
                    sum = lilie + rose;
                    if (sum == 15)
                    {
                        wreath++;
                        break;
                    }

                    else if (sum < 15)
                    {
                        flowersForLater += sum;
                        break;
                    }
                    else
                    {

                        lilie -= 2;
                        
                    }
                }
                
            }

            wreath += flowersForLater / 15;
            int neededWreaths = 5 - wreath;

            if(wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {neededWreaths} wreaths more!");
            }
        }
    }
}
