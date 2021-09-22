using System;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfCommands = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            while (countOfCommands != 0)
            {
                matrix[playerRow, playerCol] = '-';
                string command = Console.ReadLine();

                int playerPreviousRow = playerRow;
                int playerPreviousCol = playerCol;

                playerRow = MoveRow(playerRow, command);
                playerCol = MoveCol(playerCol, command);

                int[] positions = IsPositionValid(playerRow, playerCol, n, n);
                playerRow = positions[0];
                playerCol = positions[1];

                if (matrix[playerRow, playerCol] == 'B')
                {


                    playerRow = MoveRow(playerRow, command);
                    playerCol = MoveCol(playerCol, command);
                    positions = IsPositionValid(playerRow, playerCol, n, n);
                    playerRow = positions[0];
                    playerCol = positions[1];


                }
                if (matrix[playerRow, playerCol] == 'T')
                {
                    playerRow = playerPreviousRow;
                    playerCol = playerPreviousCol;
                    //matrix[playerRow, playerCol] = 'f';
                }
                if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';

                    Console.WriteLine("Player won!");
                    break;

                }
                matrix[playerRow, playerCol] = 'f';
                countOfCommands--;
            }

            if (countOfCommands <= 0)
            {
                Console.WriteLine("Player lost!");

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static int[] IsPositionValid(int row, int col, int rows, int cols)
        {
            int[] tokens = new int[] { row, col };
            if (row >= rows)
            {
                tokens[0] = 0;
                return tokens;
            }

            if (row < 0)
            {
                tokens[0] = rows - 1;
                return tokens;
            }
            if (col >= cols)
            {
                tokens[1] = 0;
                return tokens;
            }

            if (col < 0)
            {
                tokens[1] = cols - 1;
                return tokens;
            }
            return tokens;

        }
        public static int MoveRow(int row, string movemend)
        {
            if (movemend == "up")
            {
                return row - 1;
            }
            if (movemend == "down")
            {
                return row + 1;
            }
            return row;
        }
        public static int MoveCol(int col, string movemend)
        {
            if (movemend == "left")
            {
                return col - 1;
            }
            if (movemend == "right")
            {
                return col + 1;
            }
            return col;
        }
    }
}

