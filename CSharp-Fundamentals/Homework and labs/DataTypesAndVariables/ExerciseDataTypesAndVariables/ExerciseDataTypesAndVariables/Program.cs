using System;
using System.Xml;

namespace ExerciseDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int forthInteger = int.Parse(Console.ReadLine());

            int add = firstInteger + secondInteger;
            int divide = add / thirdInteger;
            int multiply = divide * forthInteger;

            Console.WriteLine(multiply);
        }
    }
}
