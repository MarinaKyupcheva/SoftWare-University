using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Bus : Vehicle
    {
        private const double BusAirConditionerFuel = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, BusAirConditionerFuel)
        {
        }

        public void TurnOnAirConditioner()
        {
            this.AirConditionerFuel = BusAirConditionerFuel;

        }

        public void TurnOfAirConditioner()
        {
            this.AirConditionerFuel = 0;
        }
        
        
    }
}
