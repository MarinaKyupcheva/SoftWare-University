using System;

namespace Vehicle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            string[] carInformation = Console.ReadLine().Split();
            string[] truckInformation = Console.ReadLine().Split();
            string[] busInformation = Console.ReadLine().Split();

            Vehicle car = CreateVehicle(carInformation);
            Vehicle truck = CreateVehicle(truckInformation);
            Vehicle bus = CreateVehicle(busInformation);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                string vehicleType = commands[1];
                double parameter = double.Parse(commands[2]);

              

                try
                {
                    if (vehicleType == nameof(Car))
                    {
                        ProcessedCommand(car, command, parameter);
                    }
                    else if (vehicleType == nameof(Bus))
                    {
                        ProcessedCommand(bus, command, parameter);
                    }
                    else if (vehicleType == nameof(Truck))
                    {
                        ProcessedCommand(truck, command, parameter);
                    }
                    
                }
                catch (Exception ex)
                when (ex is InvalidOperationException || ex is ArgumentException)

                {

                    Console.WriteLine(ex.Message);
                }
               
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessedCommand(Vehicle vehicle, string command, double parameter)
        {
            if (command == "Drive")
            {
                vehicle.Drive(parameter);
                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else if(command == "DriveEmpty")
            {
                ((Bus)vehicle).TurnOfAirConditioner();
                vehicle.Drive(parameter);
                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
                ((Bus)vehicle).TurnOnAirConditioner();
            }
                
            else if (command == "Refuel")
            {
                vehicle.Refuel(parameter);
            }

        }

        private static Vehicle CreateVehicle(string[] carInformation)
        {
            string type = carInformation[0];
            double fuel = double.Parse(carInformation[1]);
            double littersPerKm = double.Parse(carInformation[2]);
            double tankCapacity = double.Parse(carInformation[3]);

            Vehicle vehicle = null;

            if(type == nameof(Car))
            {
                vehicle = new Car(fuel, littersPerKm, tankCapacity);
            }
            else if(type == nameof(Truck))
            {
                vehicle = new Truck(fuel, littersPerKm, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuel, littersPerKm, tankCapacity);
            }

            return vehicle;
        }
    }
}
