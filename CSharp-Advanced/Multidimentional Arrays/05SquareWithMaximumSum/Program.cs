using System;
using System.Linq;

namespace _05SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elemnts = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elemnts[col];
                }
            }
            int biggestSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < matrix.GetLength(0) -1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) -1; col++)
                {
                    int sum = matrix[row, col] + matrix[row + 1, col]
                        + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if(biggestSum < sum)
                    {
                        biggestSum = sum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }

                }
               
            }

            for (int row = maxSumRow; row < maxSumRow + 2; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(biggestSum);
        }
    }
}
