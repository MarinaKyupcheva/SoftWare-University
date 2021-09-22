using System;

namespace _01TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());
            

            double totalWater = days * players * waterPerDayForOnePerson;
            double totalFood = days * players * foodPerDayForOnePerson;

            bool isBreaked = true;

            for (int i = 1; i <= days; i++)
            {
                double woodEnergy = double.Parse(Console.ReadLine());

                groupEnergy -= woodEnergy;
                if(groupEnergy <= 0)
                {
                    isBreaked = false;
                    break;
                }

                if(i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    totalWater -= totalWater * 0.30;
                }

                if(i % 3 == 0)
                {
                    totalFood -= totalFood /players;
                    groupEnergy *=  1.1;
                }
            }
            if(isBreaked)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
            }

        }
    }
}
