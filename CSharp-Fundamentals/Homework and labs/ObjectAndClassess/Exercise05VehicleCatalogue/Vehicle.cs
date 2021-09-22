using System.Text;

namespace Exercise05VehicleCatalogue
{
    class Vehicle 
    {
        public string Type{ get; set; }
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
