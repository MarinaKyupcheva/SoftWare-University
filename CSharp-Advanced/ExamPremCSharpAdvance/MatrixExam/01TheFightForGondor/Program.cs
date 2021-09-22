using System;
using System.Collections.Generic;
using System.Linq;

namespace _01TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWavesOfOrcs = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Stack<int> orcWarrior = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray());

            while (plates.Count>0 && orcWarrior.Count>0)
            {
               

                while(orcWarrior.Count <= numberOfWavesOfOrcs)
                {
                    orcWarrior = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray());
                    if (numberOfWavesOfOrcs%3 == 0)
                    {
                       string extraLine = Console.ReadLine();
                        plates.Enqueue(int.Parse(extraLine));
                        
                    }
                  
                    break;
                }

                int currentPlate = plates.Peek();
                int currentWarrior = orcWarrior.Peek();

              

                    if (currentWarrior > currentPlate)
                    {
                        orcWarrior.Pop();
                        plates.Dequeue();
                        orcWarrior.Push(-currentPlate);

                       // if(currentWarrior > currentPlate)
                       // {
                       //orcWarrior.Pop();
                       // plates.Dequeue();
                       //orcWarrior.Push(-currentPlate);
                       // }
                       // else if (currentWarrior < currentPlate)
                       // {
                       // orcWarrior.Pop();
                       // plates.Dequeue();
                       // plates.Enqueue(+currentWarrior);
                       // }
                        continue;

                    }
                    if (currentWarrior < currentPlate)
                    {
                        orcWarrior.Pop();
                        plates.Dequeue();
                        plates.Enqueue(+currentWarrior);
                       continue;
                    }
                    if(currentPlate == currentWarrior)
                    {
                        orcWarrior.Pop();
                        plates.Dequeue();
                    continue;
                    }

                continue;
            }
            if (orcWarrior.Count > 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }

            if (orcWarrior.Count > 0)
            {
                Console.WriteLine($"Orcs left: {string.Join(", ", orcWarrior)}");
            }

            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
