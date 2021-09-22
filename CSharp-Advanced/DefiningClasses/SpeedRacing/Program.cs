using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ");
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car currCar = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionPerKilometer
                };

                cars.Add(currCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmd = command.Split(" ");
                string carModel = cmd[1];
                int amountOfKm = int.Parse(cmd[2]);

                Car car = cars.First(x => x.Model == carModel);
                bool isDrive = car.CarCanMove(amountOfKm);

                if(isDrive == false)
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
               
                    

                command = Console.ReadLine();
            }

            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
