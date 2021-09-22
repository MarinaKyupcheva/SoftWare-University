using System;
using System.Linq;

namespace ExerciseMultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    
                }
            }
            int sumPrimary = 0;
            int sumSecondary = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row == col)
                    {
                        sumPrimary += matrix[row, col];
                    }
                    if (col == n -1 - row)
                    {
                        sumSecondary += matrix[row, col];
                    }
                }
            }
            
                    Console.Write(Math.Abs(sumPrimary - sumSecondary));
               
                
           
          
        }
    }
}
