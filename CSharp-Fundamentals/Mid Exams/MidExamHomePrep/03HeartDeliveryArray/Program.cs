using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03HeartDeliveryArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            int jumpPosition = 0;

            while (input != "Love!")
            {
                string[] cmdArg = input.Split(" ");
                int lenght = int.Parse(cmdArg[1]);

                jumpPosition += lenght;

                if (jumpPosition >= 0 && jumpPosition < neighborhood.Length)
                {
                    neighborhood[jumpPosition] -= 2;
                }
                else
                {
                    jumpPosition = 0;
                    neighborhood[jumpPosition] -= 2;
                }

                if(neighborhood[jumpPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpPosition} has Valentine's day.");
                }
                else if(neighborhood[jumpPosition] < 0)
                {
                    Console.WriteLine($"Place {jumpPosition} already had Valentine's day.");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {jumpPosition}.");
            int succseedMission = neighborhood.Count(x => x == 0);
            int failedMission = neighborhood.Count(x => x > 0);

            if(failedMission == 0)
            {
                Console.WriteLine($"Mission was successful.");

            }
            else
            {
                
                Console.WriteLine($"Cupid has failed {failedMission} places.");
            }
        }
    }
}
