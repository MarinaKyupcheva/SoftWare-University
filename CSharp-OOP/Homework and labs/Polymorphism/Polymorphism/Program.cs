using System;

namespace Operations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations n = new MathOperations();

            Console.WriteLine(n.Add(2, 3));
            Console.WriteLine(n.Add(2.2, 3.3, 5.5));
            Console.WriteLine(n.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
