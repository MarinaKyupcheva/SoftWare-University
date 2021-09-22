using System;
using System.Linq;

namespace _022X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int r = input[0];
            int c = input[1];
            [,] matrix = new [r, c];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                [] elements = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];

                }
            }

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) -1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                     currentElement = matrix[row, col];
                    if(currentElement == matrix[row+1, col+1] 
                        && currentElement == matrix[row+1, col] 
                        && currentElement == matrix[row, col+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
