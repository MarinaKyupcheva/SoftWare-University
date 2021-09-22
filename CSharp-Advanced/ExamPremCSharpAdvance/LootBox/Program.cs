using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> secondLootBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int sum = 0;
            int sumOf = 0;
            while (firstLootBox.Count >0 && secondLootBox.Count >0)
            {
                int firstBox = firstLootBox.Peek();
                int secondBox = secondLootBox.Peek();
                sum = firstBox + secondBox;

                if(sum%2 == 0)
                {
                    sumOf += sum;
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                    
                }
                else
                {
                    var lastItem = secondLootBox.Pop();
                    firstLootBox.Enqueue(lastItem);
                }
            }

            if(firstLootBox.Count <= 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (secondLootBox.Count <= 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if(sum>= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumOf}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumOf}");
            }
        }
    }
}
