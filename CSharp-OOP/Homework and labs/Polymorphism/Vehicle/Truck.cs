using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Truck : Vehicle
    {
        private const double TruckAirConditionerFuel = 1.6;
        public Truck(double fuelQuantity, double tankCapacity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, TruckAirConditionerFuel)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * 0.95);
        }
    }
}
