using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;
		private double health;
		private double armor;
		private double baseHealth;
		private double baseArmor;

		public Character(string name, double health, double armor, double abilityPoints, Bag bag)
		{
			this.Name = name;
			this.Health = health;
			this.Armor = armor;
			this.AbilityPoints = abilityPoints;
			this.Bag = bag;
		}
		public virtual string Name
		{
			get => this.name;
			protected set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
				}

				this.name = value;
			}
		}

		

		public double Health
		{
			get => this.health;
			set
			{
				if (value > 0 && value < this.baseHealth)
				{
					this.health = value;
				}
			}
		}

		public double Armor
		{
			get => this.armor;
			set
			{
				if (value > 0)
				{
					this.armor = value;
				}
			}
		}

		public virtual double AbilityPoints { get; protected set; }

		public virtual Bag Bag { get; protected set; }

		public bool IsAlive { get; set; } = true;

      

        public void TakeDamage(double hitPoints)
		{
			this.EnsureAlive();

			this.Armor -= hitPoints;

			if (hitPoints > 0)
			{
				this.Health -= hitPoints;
			}


			if (this.Health == 0)
			{
				this.IsAlive = false;
			}
		}

		public void UseItem(Item item)
		{
			this.EnsureAlive();

			item.AffectCharacter(this);

		}
		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}