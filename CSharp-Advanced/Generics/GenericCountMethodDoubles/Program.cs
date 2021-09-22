using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                elements.Add(input);
            }

            Box<double> box = new Box<double>(elements);

            double elementToCompare = double.Parse(Console.ReadLine());

            int countOfGreaterNumbers = box.GetComparedElement(elementToCompare);

            Console.WriteLine(countOfGreaterNumbers);
            
           

        }       
    }
}
