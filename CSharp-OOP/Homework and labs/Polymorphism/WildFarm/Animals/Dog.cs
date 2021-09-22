using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        private const double DogWeightModifier = 0.40;
        private static HashSet<string> DogAllowedFood = new HashSet<string>
        {
            nameof(Meat),
           
        };
        public Dog(string name, double weight, 
            string livingRegion)
            : base(name, weight,  livingRegion, DogAllowedFood, DogWeightModifier)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
