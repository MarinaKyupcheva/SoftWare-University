using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity,
            double airConditionerFuel)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
            this.AirConditionerFuel = airConditionerFuel;
          
        }
        public double TankCapacity { get; private set; }
        public double FuelQuantity 
        { 
            get => fuelQuantity;
            private set
            {
                if(value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }
        public double FuelConsumption { get; private set; }
        
        protected double AirConditionerFuel { get; set; }

        public void Drive(double distance)
        {
            double requiredFuel = distance * (this.FuelConsumption + this.AirConditionerFuel);
            if(requiredFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= requiredFuel;

        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException ($"Fuel must be a positive number");
            }

            if (fuelAmount + this.FuelQuantity > this.TankCapacity)
            {
              throw new InvalidOperationException($"Cannot fit {fuelAmount} fuel in the tank");
            }

            this.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }

    }
}
