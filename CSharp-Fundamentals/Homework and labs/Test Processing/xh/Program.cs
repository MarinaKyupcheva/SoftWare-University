using System;

namespace xh
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine($"{s} = {string.Join(" ", charArray)}");

        }
    }
}
