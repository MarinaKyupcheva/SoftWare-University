using System;
using System.Linq;

namespace _06JaggedArrayManipulatorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jackedArray = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jackedArray[row] = input;
                
            }

            for (int row = 0; row < n -1; row++)
            {
                double[] firstLenght = jackedArray[row];
                double[] secondLenght = jackedArray[row + 1];

                if(firstLenght.Length == secondLenght.Length)
                {
                    jackedArray[row] = firstLenght.Select(x => x * 2).ToArray();
                    jackedArray[row + 1] = secondLenght.Select(x => x * 2).ToArray();

                }
                else
                {
                    jackedArray[row] = firstLenght.Select(x => x / 2).ToArray();
                    jackedArray[row + 1] = secondLenght.Select(x => x / 2).ToArray();
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();
                string cmd = cmdArgs[0];
                int rowIndex = int.Parse(cmdArgs[1]);
                int colIndex = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                bool isValid = rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < jackedArray[rowIndex].Length;

                if (isValid)
                {
                    if (cmd == "Add")
                    {
                        jackedArray[rowIndex][colIndex] += value;
                    }
                    else if (cmd == "Subtract")
                    {
                        jackedArray[rowIndex][colIndex] -= value;
                    }
                   
                }
                else
                {
                    command = Console.ReadLine();
                    continue;
                }
               
                command = Console.ReadLine();
            }
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ",jackedArray[row]));
            }
        }
    }
}
