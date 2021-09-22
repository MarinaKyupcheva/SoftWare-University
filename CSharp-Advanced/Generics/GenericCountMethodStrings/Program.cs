using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> firstElements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string elements = Console.ReadLine();
                firstElements.Add(elements);

            }

            string valueToCompare = Console.ReadLine();

            Box<string> box = new Box<string>(firstElements);

            int countOfGreaterValues = box.GetCountOfCompareElements(valueToCompare);

            Console.WriteLine(countOfGreaterValues);

        }
    }
}
