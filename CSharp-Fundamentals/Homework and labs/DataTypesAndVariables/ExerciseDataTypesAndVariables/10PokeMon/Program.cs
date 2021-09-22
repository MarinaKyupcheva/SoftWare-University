using System;

namespace _10PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int target = 0;
            int originalValue = n;

            while (n >= m)
            {
               
                if (n == originalValue / 2)
                {
                    if (y > 0)
                    {
                        n /= y;
                        continue;

                    }
                    
                }
                n -= m;
                target++;
            }
            Console.WriteLine(n);
            Console.WriteLine(target);
        }
    }
}
