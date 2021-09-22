using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion,
            HashSet<string> allowedFood, double weightModifier) 
            : base(name, weight, allowedFood, weightModifier)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

      
    }
}
