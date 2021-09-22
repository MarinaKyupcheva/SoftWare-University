using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string input = Console.ReadLine();
            string[] split = input.Split(", ");
            int firstNumber = Int32.Parse(split[0]);
            int secondNumber = Int32.Parse(split[1]);
            


            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            
            {

                string line = Console.ReadLine();
                string[] elements = line.Split(' ');

                for (int col = 0; col < elements.Length; col++)
                {
                    matrix[row, col] = Convert.ToInt32(elements[col]);
                }
            }
                

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
