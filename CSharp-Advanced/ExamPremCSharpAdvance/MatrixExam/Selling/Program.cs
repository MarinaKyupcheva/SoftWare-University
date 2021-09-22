using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int sailorRow = 0;
            int sailorCol = 0;
            int firstPillerRow = 0;
            int firstPillerCol = 0;
            int secondPillerRow = 0;
            int secondPillerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string rows = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rows[col];
                    if(matrix[row, col] == 'S')
                    {
                        sailorRow = row;
                        sailorCol = col;
                    }

                    if(matrix[row, col] == 'O')
                    {
                        if (firstPillerRow == 0)
                        {
                            firstPillerRow = row;
                            firstPillerCol = col;
                        }
                        else
                        {
                            secondPillerRow = row;
                            secondPillerCol = col;
                        }
                    }
                }
            }

            int collectedSum = 0;

            while (true)
            {
                if (collectedSum >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }

                matrix[sailorRow, sailorCol] = '-';
                string command = Console.ReadLine();
                sailorRow = MoveRow(sailorRow, command);
                sailorCol = MoveCol(sailorCol, command);

                if(!IsValid(sailorRow, sailorCol, n, n))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                if(char.IsDigit(matrix[sailorRow, sailorCol]))
                {
                    collectedSum += (int)char.GetNumericValue(matrix[sailorRow, sailorCol]);

                }

                if (matrix[sailorRow, sailorCol] == 'O')
                {
                    matrix[sailorRow, sailorCol] = '-';

                    if (firstPillerRow == sailorRow && firstPillerCol == sailorCol)
                    {
                        sailorRow = secondPillerRow;
                        sailorCol = secondPillerCol;
                    }
                    else
                    {
                        sailorRow = firstPillerRow;
                        sailorCol = firstPillerCol;
                    }
                }

                matrix[sailorRow, sailorCol] = 'S';

            }

           
            Console.WriteLine($"Money: {collectedSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsValid(int row, int col, int rows, int cols)
        {
            if(row < 0 || row >= rows)
            {
                return false;
            }
            if(col <0 || col >= cols)
            {
                return false;
            }

            return true;
        }
        public static int MoveRow (int row, string command)
        {
            if(command == "up")
            {
                row -= 1;
            }

            if(command == "down")
            {
                row += 1;
            }

            return row;
        }
        public static int MoveCol(int col, string command)
        {
            if (command == "left")
            {
                col -= 1;
            }

            if (command == "right")
            {
                col += 1;
            }

            return col;
        }
    }
}
