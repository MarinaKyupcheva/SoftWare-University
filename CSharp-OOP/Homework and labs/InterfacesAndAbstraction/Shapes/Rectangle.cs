using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public int Height { get;  set; }
        public int Width { get;  set; }
        public void Draw()
        {
            Console.WriteLine("Drawing ractangle");
        }
    }
}
