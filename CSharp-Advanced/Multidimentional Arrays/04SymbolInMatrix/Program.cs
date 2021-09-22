using System;

namespace _04SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string symbols = Console.ReadLine();
                for (int col = 0; col < symbols.Length; col++)
                {
                    matrix[row, col] = symbols[col];
                  
                }
               

            }
            char symbol = char.Parse(Console.ReadLine());
            bool isTrue = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isTrue = true;
                        break;
                    }
                   
                }
               
            }

            if (isTrue == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
