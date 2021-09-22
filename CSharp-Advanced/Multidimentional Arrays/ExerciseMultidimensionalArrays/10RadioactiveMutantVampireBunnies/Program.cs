using System;
using System.Collections.Generic;
using System.Linq;

namespace _10RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            int playerRow = -1;
            int playerCol = -1;

            char[,] field = new char[n, m];
            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowData[col];

                    if(field[row,col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (char direction in directions)
            {
                int playerNewRow = playerRow;
                int playerNewCol = playerCol;

                if(direction == 'U')
                {
                    playerNewRow--;
                }
                else if (direction == 'D')
                {
                    playerNewRow++;
                }
                else if (direction == 'L')
                {
                    playerNewCol--;
                }
                else if (direction == 'R')
                {
                    playerNewCol++;
                }

                if(!IsValidCell(playerNewRow, playerNewCol, n, m))
                {
                    isWon = true;
                    field[playerRow, playerCol] = '.';

                    List<int[]> bunniesCordinates = GetBunniesCordinates(field);
                    SpreadBunnies(bunniesCordinates, field);
                }
                else if(field[playerNewRow, playerNewCol] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[playerNewRow, playerNewCol] = 'P';
                    playerRow = playerNewRow;
                    playerCol = playerNewCol;

                    List<int[]> bunniesCordinates = GetBunniesCordinates(field);
                    SpreadBunnies(bunniesCordinates, field);

                    if (field[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                    }

                }
                else if (field[playerNewRow, playerNewCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = playerNewRow;
                    playerCol = playerNewCol;

                    List<int[]> bunniesCordinates = GetBunniesCordinates(field);
                    SpreadBunnies(bunniesCordinates, field);
                }

              

                if(isDead || isWon)
                {
                    break;
                }
            }
            PrintField(field);
            string result = "";

            if (isWon)
            {
                result += "won";
            }
            else
            {
                result += "dead";
            }

            result += $": {playerRow} {playerCol}";
            Console.WriteLine(result);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunniesCordinates, char[,] field)
        {
            

            foreach (int[] bunnyCordinates in bunniesCordinates)
            {
                int row = bunnyCordinates[0];
                int col = bunnyCordinates[1];

                SpreadBunny(row - 1, col, field);
                SpreadBunny(row + 1, col, field);
                SpreadBunny(row, col - 1, field);
                SpreadBunny(row, col + 1, field);

                
            }
        }

        private static void SpreadBunny(int row, int col, char[,] field)
        {
            int rowsLenght = field.GetLength(0);
            int colsLenght = field.GetLength(1);

            if (IsValidCell(row, col, rowsLenght, colsLenght))
            {
                field[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunniesCordinates(char[,] field)
        {
            List<int[]> bunniesCordinates = new List<int[]>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if(field[row, col] == 'B')
                    {
                        bunniesCordinates.Add(new int[] { row, col });
                    }
                }
            } 
            return bunniesCordinates;
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
