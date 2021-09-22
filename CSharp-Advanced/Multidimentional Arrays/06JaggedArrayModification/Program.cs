using System;

namespace _06JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] splittedCommand = command.Split();
                string cmd = splittedCommand[0];
                int row = int.Parse(splittedCommand[1]);
                int col = int.Parse(splittedCommand[2]);
                int value = int.Parse(splittedCommand[3]);

                if(row >=0 && col >=0 && row < n && col < n)
                {
                    if(cmd == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    else
                    {
                        matrix[row, col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
