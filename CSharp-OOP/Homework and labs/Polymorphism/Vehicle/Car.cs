using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Car : Vehicle
    {
        private const double CarAirConditionerFuel = 0.9;
        public Car(double fuelQuantity, double tankCapacity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption, tankCapacity, CarAirConditionerFuel)
        {
        }
    }
}
