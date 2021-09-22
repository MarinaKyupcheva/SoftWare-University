using System;
using System.Collections.Generic;

namespace _07Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class VehicleCatalog
    {
        public VehicleCatalog()
        {

        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    class Truck
    {
        

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }


    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int HorsePower{ get; set; }
        
    }
    class Catalog
    {
        public string CollectionOfTrucks { get; set; }
        public string CollectionOfCars { get; set; }
    }
}
