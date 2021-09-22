using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentelement = Console.ReadLine();
                elements.Add(currentelement);

            }
            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Box<string> box = new Box<string>(elements);
            box.Swap(firstIndex, secondIndex);

            Console.Write(box.ToString());

        }
    }
}
