using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(120, 20);
            vehicle.Drive(10);
            SportCar sportCar = new SportCar(200, 50);
            sportCar.Drive(100);

            Console.WriteLine(vehicle);
        }
    }
}
