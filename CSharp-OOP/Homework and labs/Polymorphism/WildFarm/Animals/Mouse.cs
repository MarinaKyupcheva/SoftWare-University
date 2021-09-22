using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double MouseWeightModifier = 0.10;
        private static HashSet<string> MouseAllowedFood = new HashSet<string>
        {
            nameof(Fruit),
            nameof(Vegetable)
        };
        public Mouse(string name, double weight, 
            string livingRegion) 
            : base(name, weight,  livingRegion, MouseAllowedFood, MouseWeightModifier)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
