using System;
using System.Collections.Generic;
using System.Linq;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;


namespace WarCroft.Core
{
	public class WarController
	{
		private readonly List<Character> characterParty;
		private readonly List<Item> itemPool;
		public WarController()
		{
			this.characterParty = new List<Character>();
			this.itemPool = new List<Item>();
		}

		public string JoinParty(string[] args)
		{
			string characterType = args[0];
			string name = args[1];

			if(characterType == "Priest")
            {
				this.characterParty.Add(new Priest(name));
            }

			else if (characterType == "Warrior")
			{
				this.characterParty.Add(new Warrior(name));
			}
            else
			{
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType, characterType));
            }

			return string.Format(SuccessMessages.JoinParty, name);

		}

		public string AddItemToPool(string[] args)
		{
			string itemName = args[0];

			

			if(itemName == "FirePotion")
            {
				this.itemPool.Add(new FirePotion());
            }

			else if (itemName == "HealthPotion")
			{
				this.itemPool.Add(new HealthPotion());
			}
            else
            {
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem, itemName));
            }

			return string.Format(SuccessMessages.AddItemToPool, itemName);


		}

		public string PickUpItem(string[] args)
		{
			string characterName = args[0];

			var character = this.characterParty.FirstOrDefault(x => x.Name == characterName);
			var item = this.itemPool.LastOrDefault();

			if(character == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, characterName));
            }

			if(item == null)
            {
				throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

			character.Bag.AddItem(item);
			return string.Format(SuccessMessages.PickUpItem, characterName, item.GetType().Name);
		}

		public string UseItem(string[] args)
		{
			string characterName = args[0];
			string itemName = args[1];
			var character = this.characterParty.FirstOrDefault(x => x.Name == characterName);
			var item = this.characterParty.FirstOrDefault(x => x.Name == itemName);

			if(character == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, characterName));
            }

			character.Bag.GetItem(itemName);

			return string.Format(SuccessMessages.UsedItem, characterName, itemName);
		}

		public string GetStats()
		{
			var result = "";
			var characters = this.characterParty.OrderByDescending(x => x.IsAlive)
				.ThenByDescending(x => x.Health)
				.ToList();
            foreach (var character in characters)
            {
				result += $"{character.Name} - HP: {character.Health}/{character.BaseHealth}," +
					$" AP: {character.Armor}/{character.BaseArmor}, Status: {character.IsAlive}\r\n";

			}

			return result.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string receiverName = args[0];

			if(!this.characterParty.Any(x=>x.Name == attackerName))	
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, attackerName));
            }

			if(!this.characterParty.Any(x => x.Name == receiverName))
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, receiverName));
			}

			Warrior warrior = new Warrior(attackerName);

			if (!warrior.IsAlive)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.AttackFail, attackerName));
            }

			var receiver = this.characterParty.FirstOrDefault(x => x.Name == receiverName);
			warrior.Attack(receiver);

			
            if (receiver.IsAlive)
            {
				return $"{attackerName} attacks {receiverName} for {warrior.AbilityPoints} hit points! " +
					$"{receiverName} has {receiver.Health}/{receiver.BaseHealth} " +
					$"HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";

			}

            else
            {
				return $"{attackerName} attacks {receiverName} for {warrior.AbilityPoints} hit points! " +
					$"{receiverName} has {receiver.Health}/{receiver.BaseHealth} " +
					$"HP and {receiver.Armor}/{receiver.BaseArmor} AP left!\r\n" +
					$"{receiver.Name} is dead!";
			}
			
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string healingReceiverName = args[1];

			if (!this.characterParty.Any(x => x.Name == healerName))
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healerName));
			}

			if (!this.characterParty.Any(x => x.Name == healingReceiverName))
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healingReceiverName));
			}

			Priest healer = new Priest(healerName);

			if (!healer.IsAlive)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.HealerCannotHeal, healerName));
			}
			var receiver = this.characterParty.FirstOrDefault(x => x.Name == healingReceiverName);

			healer.Heal(receiver);

			return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}!" +
				$" {receiver.Name} has {receiver.Health} health now!";

		}
	}
}
