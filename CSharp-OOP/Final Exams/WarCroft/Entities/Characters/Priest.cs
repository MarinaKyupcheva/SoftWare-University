using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
    
        public Priest(string name) 
            : base(name, 50,25, 40, new Backpack())
        {
            Name = name;
        }

        public override string Name { get; protected set; }
        public override double BaseHealth { get; protected set; } = 50;
       
        public override double BaseArmor { get; protected set; } = 25;
        public override double AbilityPoints { get; protected set; } = 40;
        public override Bag Bag { get; protected set; } = new Backpack();

        public void Heal(Character character)
        {
            if(this.IsAlive && character.IsAlive)
            {
                character.Health += this.AbilityPoints;
            }
        }
    }
}
