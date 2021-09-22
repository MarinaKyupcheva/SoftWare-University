using System;
using System.Linq;

namespace _02TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagon = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int peopleOnTheWagoon = 0;
            int peopleOnTheLift = 0;
            bool noMorePople = false;


            for (int i = 0; i <= wagon.Length - 1; i++)
            {
                while (wagon[i] < 4)
                {
                    wagon[i]++;
                    peopleOnTheWagoon++;
                    if (peopleOnTheLift + peopleOnTheWagoon == people)
                    {
                        noMorePople = true;
                        break;
                    }
                }
                peopleOnTheLift += peopleOnTheWagoon;
                if (noMorePople)
                {
                    break;
                }
                peopleOnTheWagoon = 0;
            }
            if (people > peopleOnTheLift)
            {
                Console.WriteLine($"There isn't enough space! {people - peopleOnTheLift} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (people < wagon.Length * 4 && wagon.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            //else if (peopleonTheLyft == peopleWaitingForLyft && NoMorePeople == true)
            else if (wagon.All(w => w == 4) && noMorePople == true)
            {
                Console.WriteLine(string.Join(" ", wagon));
            }
        }
    }
}
