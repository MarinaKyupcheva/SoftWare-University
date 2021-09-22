using System;
using System.Collections.Generic;

namespace _06ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {


            HashSet<string> cars = new HashSet<string>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = Console.ReadLine().Split(", ");
                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                {
                    cars.Add(carNumber);

                    if (direction == "OUT")
                    {
                        cars.Remove(carNumber);
                    }
                }
                

                command = Console.ReadLine();
          

             }
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                    Console.WriteLine(car);
                {
                }
                
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
