using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public double Height { get; private set; }
        public double Width { get; private set; }
       
        public override double CalculateArea()
        {
            return 2 * height + 2 * width;
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}
