using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Martin", 2);
            Console.WriteLine(hero);
        }
    }
}
