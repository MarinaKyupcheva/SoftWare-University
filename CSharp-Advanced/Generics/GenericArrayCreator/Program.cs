using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(2, 2);
            Console.WriteLine(string.Join(", ", strings));
            Console.WriteLine(string.Join(", ", integers));
        }
    }
}
