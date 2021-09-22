using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bankVault = new BankVault();
        private Item item;

        [SetUp]
        public void Setup()
        {
            this.bankVault = new BankVault();
            this.item = new Item("me", "1");
        }

        [Test]
        public void AddItemInCollection()
        {
            string result = bankVault.AddItem("B3", item);

            Assert.That(result, Is.EqualTo($"Item:{item.ItemId} saved successfully!"));
             
           

        }

        [Test]
        public void AddItem_WhenVaultDoesNotContainsCell()
        {
            Exception message = Assert.Throws<ArgumentException>(() =>
            {
                this.bankVault.AddItem("kr", item);
            });

            Assert.That(message.Message, Is.EqualTo("Cell doesn't exists!"));

        }

        [Test]
        public void AddItem_WhenCellIsAlreadyTaken()
        {
            Exception message = Assert.Throws<ArgumentException>(() =>
            {
                this.bankVault.AddItem("B2", item);
                this.bankVault.AddItem("B2", new Item("Iv", "12"));
            });

            Assert.That(message.Message, Is.EqualTo("Cell is already taken!"));

        }
        [Test]
        public void AddItem_WhenItemIsAlreadyInCell()
        {
            Exception message = Assert.Throws<InvalidOperationException>(() =>
            {
                this.bankVault.AddItem("B2", item);
                this.bankVault.AddItem("B3", item);
            });

            Assert.That(message.Message, Is.EqualTo("Item is already in cell!"));

        }

        [Test]
        public void RemoveItem_WhenCellDoesNotExist()
        {
            this.bankVault.AddItem("B2", item);
            
            Exception message = Assert.Throws<ArgumentException>(() =>
            {
                this.bankVault.RemoveItem("kw", item);
            });

            Assert.That(message.Message, Is.EqualTo("Cell doesn't exists!"));

        }

        [Test]
        public void RemoveItem_WhenItemDoesNotExist()
        {
            this.bankVault.AddItem("B2", item);

            Exception message = Assert.Throws<ArgumentException>(() =>
            {
                this.bankVault.RemoveItem("B2", new Item("Sam", "15"));
            });

            Assert.That(message.Message, Is.EqualTo($"Item in that cell doesn't exists!"));

        }

        [Test]
        public void RemoveItem_WhenIsValidOperation()
        {
            this.bankVault.AddItem("B2", item);

            string result = bankVault.RemoveItem("B2", item);

            Assert.That(result, Is.EqualTo($"Remove item:{item.ItemId} successfully!"));
            

        }

        [Test]
        public void CtorItems()
        {
            Assert.That(this.bankVault.VaultCells.Count, Is.EqualTo(12));
        }
    }
}