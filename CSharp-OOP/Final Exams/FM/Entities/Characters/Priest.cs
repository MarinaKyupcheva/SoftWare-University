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
            : base(name, 40, 50, 25, new Backpack())
        {
            Name = name;
        }



        public override string Name { get; protected set; } 
       
        public override double AbilityPoints { get; protected set; }
        public override Bag Bag { get; protected set; } 
        public void Heal(Character character)
        {
            if(this.IsAlive && character.IsAlive)
            {
                character.Health += this.AbilityPoints;
            }
        }
    }
}
