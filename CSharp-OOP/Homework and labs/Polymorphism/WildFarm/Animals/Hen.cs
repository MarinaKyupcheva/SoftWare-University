using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        private const double HenWeightModifier = 0.35;
        private static HashSet<string> BaseAllowedFood = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)

        };
        public Hen(string name, double weight,  double wingSize) 
            :base(name, weight, wingSize, BaseAllowedFood, HenWeightModifier)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
