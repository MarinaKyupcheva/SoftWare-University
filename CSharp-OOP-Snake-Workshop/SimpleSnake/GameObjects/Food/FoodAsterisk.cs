using System;
using System.Collections.Generic;
using System.Text;
using SimpleSnake.GameObjects;

namespace SimpleSnake.GameObjects
{
    public class FoodAsterisk : Food
    {
        private const char foodSymbol = '*';
        private const int points = 1;
        private const ConsoleColor color = ConsoleColor.Red;
        public FoodAsterisk(Wall wall) 
            : base(wall, foodSymbol, points, color)
        {
        }

       
    }
}
