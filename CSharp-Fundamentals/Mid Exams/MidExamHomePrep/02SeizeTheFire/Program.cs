using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fires = Console.ReadLine().Split("#").ToArray();
            int water = int.Parse(Console.ReadLine());
            double effort = 0;
            List<int> fireCells = new List<int>();

            for (int i = 0; i < fires.Length; i++)
            {
                string[] fireArgs = fires[i].Split(" = ");
                string typeOfFire = fireArgs[0];
                int volumeOfCell = int.Parse(fireArgs[1]);

                bool isCellValid = IsCellValid(typeOfFire, volumeOfCell);
                if (isCellValid && water - volumeOfCell >=0)
                {
                    water -= volumeOfCell;
                    effort += volumeOfCell * 0.25;
                    fireCells.Add(volumeOfCell);

                }

            }
            int totalFire = fireCells.Sum();

            Console.WriteLine($"Cells: ");
            foreach (var cell in fireCells)
            {
                Console.WriteLine($" - {cell}");
            }
            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
        private static bool IsCellValid(string typeOfFire, int volumeOfCell)

        {
            if (typeOfFire == "High")
            {
                return volumeOfCell >= 81 && volumeOfCell <= 125;
            }
            if (typeOfFire == "Medium")
            {
                return volumeOfCell >= 51 && volumeOfCell <= 80;
            }
            if (typeOfFire == "Low")
            {
                return volumeOfCell >= 1 && volumeOfCell <= 50;
            }
            return false;
        }
    }
}
