using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight,  HashSet<string> allowedFood, double weightModifier)
        {
            this.AllowedFood = allowedFood;
            this.WeightModifier = weightModifier;
            this.Name = name;
            this.Weight = weight;
           
        }

        private double WeightModifier { get; set; }
        private HashSet<string> AllowedFood { get; set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            if (!AllowedFood.Contains(food.GetType().Name))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;

            this.Weight += this.WeightModifier * food.Quantity;
        }
    }
}
