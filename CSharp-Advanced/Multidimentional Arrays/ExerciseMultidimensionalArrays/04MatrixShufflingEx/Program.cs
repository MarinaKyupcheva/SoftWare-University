using System;
using System.Linq;

namespace _04MatrixShufflingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[]rowData = Console.ReadLine().Split(" ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                }

            }

            

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "END")
                {
                    break;
                }
                string[] splittedCommand = command.Split(" ");
                string cmd = splittedCommand[0];
                int row1 = int.Parse(splittedCommand[1]);
                int col1 = int.Parse(splittedCommand[2]);
                int row2 = int.Parse(splittedCommand[3]);
                int col2 = int.Parse(splittedCommand[4]);

                if(splittedCommand.Length != 5 || cmd != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                bool isValidOne = row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols;
                bool isValidTwo = row2 >= 0 && row2 < rows && col2 >= 0 && col2 < cols;

                if(!isValidOne || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                
                    string valueOne = matrix[row1, col1];
                    string valueTwo = matrix[row2, col2];

                    matrix[row1, col1] = valueTwo;
                    matrix[row2, col2] = valueOne;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }



            }


        }
    }
}
