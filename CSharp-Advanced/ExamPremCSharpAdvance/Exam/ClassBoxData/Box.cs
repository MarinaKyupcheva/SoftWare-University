using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length 
        {
            get => this.length;
            
            private set
            {

                this.ThrowIfValidateSides(value, nameof(this.Length));
                
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                this.ThrowIfValidateSides(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                this.ThrowIfValidateSides(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.Height * this.Length + 2 * this.Width * this.Height;
        }

        public double Volume()
        {
            return this.Width * this.Height * this.Length;
        }

        public double SurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }
        private void ThrowIfValidateSides(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
            
        }
    }
}
