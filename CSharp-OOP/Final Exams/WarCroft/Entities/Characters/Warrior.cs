using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        
        public Warrior(string name) 
            : base(name, 100, 50, 40, new Satchel())
        {
            this.Name = name;
        }
        //IsThatCorrect
        public override string Name { get; protected set; }
        public override double BaseHealth { get; protected set; } = 100;
        public override double BaseArmor { get; protected set; } = 50;
        public override double AbilityPoints { get; protected set; } = 40;
        public override Bag Bag { get; protected set; } = new Satchel();

        public void Attack(Character character)
        {
            if(this.IsAlive && character.IsAlive)
            {
                if (this.GetType().Name.Equals(character.Name))
                {
                    throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
                }

                character.TakeDamage(this.AbilityPoints);
            }
        }
    }
}
