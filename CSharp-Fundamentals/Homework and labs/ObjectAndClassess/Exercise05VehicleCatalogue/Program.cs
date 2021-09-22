using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise05VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split(" ");
                string type = cmdArg[0].ToLower();
                string model = cmdArg[1].ToLower();
                string color = cmdArg[2];
                int Hp = int.Parse(cmdArg[3]);

                Vehicle currVehicle = new Vehicle(type, model, color, Hp);
                catalogue.Add(currVehicle);

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();
            while (secondCommand != "Close the Catalogue")
            {
                string[] modelsOfVehicles = secondCommand.Split(" ");
                Vehicle printCar = catalogue.First(x => x.Model == modelsOfVehicles);

                Console.WriteLine(printCar);
                secondCommand = Console.ReadLine();
            }

            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double onlyCarsHp = onlyCars.Sum(x => x.HoursePower);
            double onlyTrucksHp = onlyTrucks.Sum(x => x.HoursePower);

            double avrCarsHp = 0.00;
            double avrTrucksHp = 0.00;

            if (avrCarsHp > 0)
            {
                avrCarsHp = onlyCarsHp / onlyCars.Count;
            }
            if (avrTrucksHp > 0)
            {
                avrTrucksHp = onlyTrucksHp / onlyTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {avrCarsHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrTrucksHp:f2}.");

        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int hoursepower)
        {
            Type = type;
            Model = model;
            Color = color;
            HoursePower = hoursePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HoursePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Truck" : "Car")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"HoursePower: {HoursePower}");


            return sb.ToString().TrimEnd();
        }

    }

}
