using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, 
            string livingRegion, HashSet<string> allowedFood, double weightModifier, string breed) 
            : base(name, weight, livingRegion, allowedFood, weightModifier)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, { this.LivingRegion}," +
                $" { this.FoodEaten}]";
        }
    }
}
