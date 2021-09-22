using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
       
        private readonly List<Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            items = new List<Item>();
        }
        public int Capacity { get; set; } = 100;
        

        public int Load { get => items.Sum(x => x.Weight); }

        public IReadOnlyCollection<Item> Items => items.AsReadOnly();

        public void AddItem(Item item)
        {
            int currentLoad = this.Load + item.Weight;

            if(currentLoad > this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }

            this.items.Add(item);
        }


        public Item GetItem(string name)
        {
            if(this.items.Count <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }

            

            if (!this.items.Any(x => x.GetType().Name == name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }

            var item = this.items.FirstOrDefault(x => x.GetType().Name == name);
            this.items.Remove(item);

            //IsThatCorrect


            return item;
        }
    }
}
