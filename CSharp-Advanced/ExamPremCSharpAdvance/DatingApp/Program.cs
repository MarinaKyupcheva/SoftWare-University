using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> female = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> male = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int sum = 0;

            while (female.Count > 0 && male.Count > 0)
            {
                int currentFemale = female.Peek();
                int curremtMale = male.Peek();
               
                if (curremtMale <= 0)
                {
                    male.Pop();
                    continue;
                }
                if (currentFemale <= 0)
                {
                    female.Dequeue();
                    continue;
                }
                if (curremtMale % 25 == 0)
                {
                    male.Pop();
                    if (male.Count > 0)
                    {
                        male.Pop();
                    }

                    continue;
                }
                if (currentFemale % 25 == 0)
                {
                    female.Dequeue();
                    if (female.Count > 0)
                    {
                        female.Dequeue();
                    }
                    continue;
                }


                if (currentFemale == curremtMale)
                {
                    sum++;
                    female.Dequeue();
                    male.Pop();

                }
                else
                {
                    female.Dequeue();
                    male.Pop();
                    male.Push(curremtMale - 2);
                }


            }

            Console.WriteLine($"Matches: {sum}");
            if (male.Count <= 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", male)}");
            }
            if (female.Count <= 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", female)}");
            }
        }
    }
}
