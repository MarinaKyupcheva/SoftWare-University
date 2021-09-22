using System;

namespace Problem01CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int wins = 0;
            int battles = 0;
            bool isWinner = true;
            while (input?.ToLower() != "end of battle")
            {
                battles++;
                int distance = int.Parse(input);
                

                if (energy< distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and { energy} energy");
                    isWinner = false;
                    break;
                }

                wins++;
                energy -= distance;


                if (battles%3 == 0)
                {
                    energy += wins;
                }

                input = Console.ReadLine();
            }
            if (isWinner)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: { energy}");
            }
        }
    }
}
