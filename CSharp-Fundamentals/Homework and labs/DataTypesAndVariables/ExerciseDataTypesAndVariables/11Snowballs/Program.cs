using System;
using System.Numerics;

namespace _11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

           BigInteger highestValue = int.MinValue;
            short highestSnow = 0;
            short highestTime = 0;
            short highestQuality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                short snowBallSnow =short.Parse(Console.ReadLine());
                short snowBallTime = short.Parse(Console.ReadLine());
                byte snowBallQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow ((snowBallSnow / snowBallTime), snowBallQuality);

                if (snowBallQuality > highestValue)
                {
                    highestValue = snowballValue;
                    highestSnow = snowBallSnow;
                    highestTime = snowBallTime;
                    highestQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({ highestQuality})");
        }
    }
}
