using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize, 
            HashSet<string> allowedFood, double weightModifier) 
            : base(name, weight, allowedFood, weightModifier)
        {
            this.Wingsize = wingSize;
        }

        public double Wingsize { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Wingsize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
