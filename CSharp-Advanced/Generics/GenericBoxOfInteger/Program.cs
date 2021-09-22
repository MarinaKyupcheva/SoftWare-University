using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());

            for(int i=0; i < numberOfIntegers; i++)
            {
                int currentelement = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(currentelement);
                Console.WriteLine(box);
            }
        }
    }
}
