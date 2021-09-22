using System;

namespace MatrixExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int snakeRow = 0;
            int snakeCol = 0;
            int firstBurrowRow = 0;
            int firstBurrowCol = 0;
            int secondBurrowRow = 0;
            int secontBurrowCol = 0;

            for (int row = 0; row < n; row++)
            {
                string rows = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rows[col];
                    if(matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    if (matrix[row, col] == 'B')
                    {
                        if (firstBurrowRow == 0)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                        }
                        else
                        {
                            secondBurrowRow = row;
                            secontBurrowCol = col;
                        }
                    }
                }
            }

            int foodQuantity = 0;
            while (true)
            {
                if (foodQuantity >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
                string command = Console.ReadLine();
                matrix[snakeRow, snakeCol] = '.';
                snakeRow = MoveRow(snakeRow, command);
                snakeCol = MoveCol(snakeCol, command);

                if(!IsValidMove(snakeRow, snakeCol, n, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if(matrix[snakeRow, snakeCol] == '*')
                {
                    foodQuantity += 1;
                }

                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (firstBurrowRow == snakeRow && firstBurrowCol == snakeCol)
                    {
                        snakeRow = secondBurrowRow;
                        snakeCol = secontBurrowCol;

                    }
                    else
                    {
                        snakeRow = firstBurrowRow;
                        snakeCol = firstBurrowCol;
                    }


                }
                matrix[snakeRow, snakeCol] = 'S';
            }

           

            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

           
        }
        public static bool IsValidMove(int row, int col, int rows, int cols)
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
        public static int MoveRow(int row, string command)
        {
            if(command == "up")
            {
                return row -= 1;
            }
            if(command == "down")
            {
                return row += 1;
            }
            return row;
        }

        public static int MoveCol(int col, string command)
        {
            if(command == "left")
            {
                return col -= 1;
            }
            if(command == "right")
            {
                return col += 1;
            }

            return col;
        }
    }
}
