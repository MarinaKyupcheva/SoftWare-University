using System;

namespace CustomDataStructures
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack myCustomStack = new CustomStack();

            for (int i = 1; i <= 5; i++)
            {
                myCustomStack.Push(i);
            }
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(myCustomStack.Pop());
                Console.WriteLine(myCustomStack.Peek());
            }
            //myCustomStack.ForEach(Console.WriteLine);
           
        }
    }
}
