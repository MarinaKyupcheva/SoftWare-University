using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars
{
    public class SportsCar : Car
    {
        private const double ConstCubicCentimeters = 3000;
        private const int ConstMinHorsePower = 250;
        private const int ConstMaxHorsePower = 450;
        public SportsCar(string model, int horsePower)
            : base(model, horsePower, ConstCubicCentimeters, ConstMinHorsePower, ConstMaxHorsePower)
        {
        }
    }
}
