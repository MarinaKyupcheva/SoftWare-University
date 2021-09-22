using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        private const double CatWeightModifier = 0.30;
        private static HashSet<string> BaseAllowedFood = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
           

        };
        

        public Cat(string name, double weight, 
            string livingRegion, string breed) 
            : base(name, weight, livingRegion, BaseAllowedFood, CatWeightModifier, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
