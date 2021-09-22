using System;

namespace _03ExtractFileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine().Split(@"\");

            var lastFile = path[path.Length - 1];
            var array = lastFile.Split(".");
            string name = array[0];
            string extension = array[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
