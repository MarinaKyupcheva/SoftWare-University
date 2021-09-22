using System;
using System.Linq;

namespace _04MatrixShufflingEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            char[,] matrix = new char[n, m];

            string snakeName = Console.ReadLine();
            int currentLetter = 0;

            for (int row = 0; row < n; row++)
            {
                if(row %2 == 0)
                {
                    for (int col = 0; col < m; col++)
                    {
                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;
                        if(currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }

                }
                else
                {
                    for (int col = m-1; col >=0; col--)
                    {
                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;
                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }

            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}