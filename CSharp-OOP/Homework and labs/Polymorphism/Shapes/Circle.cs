using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius { get; private set; }
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
            return radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}
