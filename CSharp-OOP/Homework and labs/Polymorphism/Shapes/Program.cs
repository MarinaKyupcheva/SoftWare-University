﻿using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5.5);
            Shape rectangle = new Rectangle(5.5, 5.5);

            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());
        }
    }
}
