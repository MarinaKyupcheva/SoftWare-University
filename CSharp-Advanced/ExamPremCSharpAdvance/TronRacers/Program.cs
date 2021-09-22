using System;

namespace TronRacers
{
    class Program
    {
        static char [][] battleField;

        static int firstPlayeRow;
        static int firstPlayeCol;

        static int secondPlayeRow;
        static int secondPlayeCol;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            battleField = new char[rows][];
            Initialize();

            while (true)
            {
                string[] directions = Console.ReadLine().Split();
                string firstPlayerDirection = directions[0];
                string secondPlayerDirection = directions[1];

                if(firstPlayerDirection == "down")
                {
                    firstPlayeRow++;
                    if(firstPlayeRow == battleField.Length)
                    {
                        firstPlayeRow = 0;
                    }
                }

                else if (firstPlayerDirection == "up")
                {
                    firstPlayeRow--;
                    if (firstPlayeRow < 0)
                    {
                        firstPlayeRow = battleField.Length-1;
                    }
                }
                else if (firstPlayerDirection == "left")
                {
                    firstPlayeCol--;
                    if (firstPlayeCol < 0)
                    {
                        firstPlayeCol = battleField[firstPlayeRow].Length - 1;
                    }
                }
                else if (firstPlayerDirection == "right")
                {
                    firstPlayeCol++;
                    if (firstPlayeCol == battleField[firstPlayeRow].Length)
                    {
                        firstPlayeCol = 0;
                    }
                }

                if (battleField[firstPlayeRow][firstPlayeCol] == 's')
                {
                    battleField[firstPlayeRow][firstPlayeCol] = 'x';

                    End();
                }

                else
                {
                    battleField[firstPlayeRow][firstPlayeCol] = 'f';
                }

                if (secondPlayerDirection == "down")
                {
                    secondPlayeRow++;
                    if (secondPlayeRow == battleField.Length)
                    {
                        secondPlayeRow = 0;
                    }
                }

                else if (secondPlayerDirection == "up")
                {
                    secondPlayeRow--;
                    if (secondPlayeRow < 0)
                    {
                        secondPlayeRow = battleField.Length - 1;
                    }
                }
                else if (secondPlayerDirection == "left")
                {
                    secondPlayeCol--;
                    if (secondPlayeCol < 0)
                    {
                        secondPlayeCol = battleField[secondPlayeRow].Length - 1;
                    }
                }
                else if (secondPlayerDirection == "right")
                {
                    secondPlayeCol++;
                    if (secondPlayeCol == battleField[secondPlayeRow].Length)
                    {
                        secondPlayeCol = 0;
                    }
                }
                if (battleField[secondPlayeRow][secondPlayeCol] == 'f')
                {
                    battleField[secondPlayeRow][secondPlayeCol] = 'x';

                    End();
                }
                else
                {
                    battleField[secondPlayeRow][secondPlayeCol] = 's';
                }

            }

        }

        private static void End()
        {
            for (int row = 0; row < battleField.Length; row++)
            {
                for (int col = 0; col < battleField[row].Length; col++)
                {
                    Console.Write(battleField[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        private static void Initialize()
        {
            for (int row = 0; row < battleField.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                battleField[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    battleField[row][col] = input[col];

                    if(battleField[row][col] == 'f')
                    {
                        firstPlayeRow = row;
                        firstPlayeCol = col;
                    }
                    else if(battleField[row][col] == 's')
                    {
                        secondPlayeRow = row;
                        secondPlayeCol = col;
                    }
                }
            }
        }
    }
}
