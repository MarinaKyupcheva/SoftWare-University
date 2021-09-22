using System;
using System.Linq;

namespace _02SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elemets = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[elemets[0], elemets[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int [] elementsCol = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementsCol[col];
                }
            }

           

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfColomns = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfColomns += matrix[row, col];
                   
                }
                Console.WriteLine(sumOfColomns);
            }
            
        }
    }
}
