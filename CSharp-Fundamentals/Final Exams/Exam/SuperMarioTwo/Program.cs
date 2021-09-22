using System;
using System.Linq;

namespace ExamPreparation_20_June_2019
{
    public class StartUp
    {
        static int marioRow;
        static int marioCol;

        public static void Main()
        {
            //Read the input
            //  --Energy, fieldRows, field
            //Initialize matrix
            //While Paris alive and not won
            //  -Process turn
            //      --Spawn spartans
            //      --Move Paris
            //      --Check next Position
            //          #S -> Decrease energy
            //          #H -> Win the game
            //Print Output

            int lifes = int.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());

            char[][] field = new char[rowsCount][];

            InitializeMatrix(field);

            FindMarioPosition(field);

            bool won = false;

            while (lifes > 0)
            {
                string[] turn = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string moveDirection = turn[0];
                int spawnRow = int.Parse(turn[1]);
                int spawnCol = int.Parse(turn[2]);

                SpawnSpartans(field, spawnRow, spawnCol);

                field[marioRow][marioCol] = '-';

                MoveInDirection(field, moveDirection);
                lifes--;

                char symbolOnNextStep = field[marioRow][marioCol];

                if (symbolOnNextStep == 'B')
                {
                    lifes -= 2;
                    field[marioRow][marioCol] = 'X';
                }
                else if (symbolOnNextStep == 'P')
                {
                    won = true;
                    field[marioRow][marioCol] = '-';
                    break;
                }
                else if (symbolOnNextStep == '-')
                {
                    field[marioRow][marioCol] = 'M';
                }

                if (lifes <= 0)
                {
                    field[marioRow][marioCol] = 'X';
                    break;
                }
            }

            PrintOutput(field, won, lifes);
        }

        private static void PrintOutput(char[][] field, bool won, int lifes)
        {
            if (won)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lifes}");
            }
            else
            {
                Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
            }

            PrintMatrix(field);
        }

        private static void PrintMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = field[row];

                Console.WriteLine(String.Join("", currentRow));
            }
        }

        private static void MoveInDirection(char[][] field, string moveDirection)
        {
            if (moveDirection == "W")
            {
                if (marioRow - 1 >= 0)
                {
                    marioRow--;
                }
            }
            else if (moveDirection == "S")
            {
                if (marioRow + 1 < field.Length)
                {
                    marioRow++;
                }
            }
            else if (moveDirection == "A")
            {
                if (marioCol - 1 >= 0)
                {
                    marioCol--;
                }
            }
            else if (moveDirection == "D")
            {
                if (marioCol + 1 < field[marioRow].Length)
                {
                    marioCol++;
                }
            }
        }

        private static void SpawnSpartans(char[][] field, int spawnRow, int spawnCol)
        {
            field[spawnRow][spawnCol] = 'B';
        }

        private static void FindMarioPosition(char[][] field)
        {
            bool found = false;

            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    char symbol = field[row][col];

                    if (symbol == 'M')
                    {
                        marioRow = row;
                        marioCol = col;

                        found = true;

                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }
        }

        private static void InitializeMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();

                field[row] = currentRow;
            }
        }
    }
}