using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPremCSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");
            Stack<string> hallsAndPeople = new Stack<string>(input);
            Queue<string> halls = new Queue<string>();
            List<int> groups = new List<int>();
            int currentCapacity = 0;

            while (hallsAndPeople.Count > 0)
            {
                string currentElement = hallsAndPeople.Pop();

                bool isNumber = int.TryParse(currentElement, out int parsedNumber);

                if (!isNumber)
                {
                    halls.Enqueue(currentElement);
                }


                else
                {
                    if(halls.Count == 0)
                    {
                        continue;
                    }
                    if(parsedNumber + currentCapacity > capacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", groups)}");
                        groups.Clear();
                        currentCapacity = 0;
                    }
                    if(halls.Count > 0)
                    {
                        groups.Add(parsedNumber);
                        currentCapacity += parsedNumber;
                    }
                  
                }
            }
        }
    }
}
