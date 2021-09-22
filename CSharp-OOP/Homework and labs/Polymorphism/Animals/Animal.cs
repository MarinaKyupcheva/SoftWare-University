using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        protected Animal(string name, string favoiriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favoiriteFood;
        }
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";

        }
    }
}
