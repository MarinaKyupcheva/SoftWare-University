using System;

namespace DateModifierProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firtsDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDiffBetwenDays(firtsDate, secondDate);
            Console.WriteLine(days);
        }
    }
}
