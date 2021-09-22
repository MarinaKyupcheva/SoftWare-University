using System;
using System.IO;
using System.Linq;

namespace _03MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int r = input[0];
            int c = input[1];
            int[,] matrix = new int[r, c];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];

                }
            }

            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < r-2; row++)
            {
                for (int col = 0; col < c-2; col++)
                {
                    int sum = matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];
                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];
                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            
            for (int row = maxRowIndex; row <= maxRowIndex+2; row++)
            {
                for (int col = maxColIndex; col <= maxColIndex+2; col++)
                {
                   
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
