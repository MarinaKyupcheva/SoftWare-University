using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double TigerWeightModifier = 1.00;
        private static HashSet<string> BaseAllowedFood = new HashSet<string>
        {
            nameof(Meat),
            
        };


        public Tiger(string name, double weight, 
            string livingRegion, string breed)
            : base(name, weight,  livingRegion, BaseAllowedFood, TigerWeightModifier, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
