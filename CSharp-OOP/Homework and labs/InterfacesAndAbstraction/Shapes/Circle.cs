using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
       
        public Circle(int radious)
        {
            this.Radious = radious;

        }
        public int Radious { get; private set; }

        public void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}
