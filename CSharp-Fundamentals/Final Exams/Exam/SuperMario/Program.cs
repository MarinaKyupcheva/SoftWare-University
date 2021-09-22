using System;
using System.Linq;

namespace SuperMario
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int livesOfMario = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,]matrix = new char[n, n];

            int marioRow = -1;
            int marioCol = -1;
            int bownerRow = -1;
            int bownerCol = -1;
            int princesRow = -1;
            int princesCol = -1;
            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                   if (matrix[row, col] == 'B')
                   {
                       bownerRow = row;
                        bownerCol = col;
                   }
                    if (matrix[row, col] == 'P')
                    {
                       princesRow = row;
                        princesCol = col;
                    }
                }
            }

           

            while (true)
            {

                char[] commands = Console.ReadLine().ToCharArray();
                char directionOfMario = commands[0];
                int enemyRow = (int)commands[1];
                int enemyCol = (int)commands[2];

                if(directionOfMario == 'W')
                {
                    marioRow--;
                    livesOfMario--;
                    if (!IsPositionValid(marioRow, marioCol, n, n))
                    {
                        marioRow = 0;
                        livesOfMario--;
                    }
                   
                }

                else if(directionOfMario == 'S')
                {
                    marioRow++;
                    livesOfMario--;
                    if(!IsPositionValid(marioRow, marioCol, n, n)) //!!!!
                    {
                        marioRow = matrix.Length;
                        livesOfMario--;
                    }
                    
                }

                else if(directionOfMario == 'A')
                {
                    marioCol--;
                    livesOfMario--;
                    if(!IsPositionValid(marioRow, marioCol, n, n))
                    {
                        marioCol = 0;
                        livesOfMario--;
                    }
                   
                }
                else if(directionOfMario == 'D')
                {
                    marioCol++;
                    livesOfMario--;
                    if(!IsPositionValid(marioRow, marioCol, n, n)) //!!!!
                    {
                        marioCol = matrix.Length;
                        livesOfMario--;
                    }
                   
                }

                if (matrix[enemyRow, enemyCol] == 'B')
               {
                  livesOfMario -= 2;
                 if (livesOfMario <= 0)
                    {
                       matrix[marioRow, marioCol] = 'X';
                        break;
                    }
               }




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

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
    }
}
