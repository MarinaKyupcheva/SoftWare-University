using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars
{
    public class MuscleCar : Car
    {
        private const double ConstCubicCentimeters = 5000;
        private const int ConstMinHorsePower = 400;
        private const int ConstMaxHorsePower = 600;
        public MuscleCar(string model, int horsePower)
            : base(model, horsePower, ConstCubicCentimeters, ConstMinHorsePower, ConstMaxHorsePower)
        {
        }
    }
}
