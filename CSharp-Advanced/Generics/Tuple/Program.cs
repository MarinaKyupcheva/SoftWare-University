using System;
using System.Linq;

namespace Tuple
{
   public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split(" ").ToArray();
            string name = $"{inputOne[0]} {inputOne[1]}";
            string address = inputOne[2];

            Tuple<string, string> person = new Tuple<string, string>(name, address);
            Console.WriteLine(person);

            string[] inputTwo = Console.ReadLine().Split(" ").ToArray();
            string nameInputTwo = inputTwo[0];
            int beers = int.Parse(inputTwo[1]);

            Tuple<string, int> personTwo = new Tuple<string, int>(nameInputTwo, beers);
            Console.WriteLine(personTwo);

            string[] inputThree = Console.ReadLine().Split(" ").ToArray();
            int integer = int.Parse(inputThree[0]);
            double doubleer = double.Parse(inputThree[1]);

            Tuple<int, double> numbers = new Tuple<int, double>(integer, doubleer);
            Console.WriteLine(numbers);
        }
    }
}
