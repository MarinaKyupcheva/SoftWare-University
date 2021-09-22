using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Computers.Tests
{
    public class Tests
    {
        private ComputerManager computerManager = new ComputerManager();
        private Computer computer = new Computer("Asus", "Duck", 1000);

        [SetUp]
        public void Setup()
        {
            this.computerManager = new ComputerManager();
            this.computer = new Computer("Asus", "Duck", 1000);
        }

        [Test]
        public void AddComputer_WhenComputerIsNull_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => computerManager.AddComputer(null));
        }

        [Test]
        public void AddComputer_WhenComputerAlreadyExist_ThrowException()
        {
            this.computerManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(computer));
        }
        [Test]
        public void AddComputer_WhenIsValidOperation()
        {
            this.computerManager.AddComputer(computer);
            Assert.That(this.computerManager.Count, Is.EqualTo(1));

        }

        [Test]
        public void RemoveComputer_WhenIsValidOperation()
        {
            this.computerManager.AddComputer(computer);
            this.computerManager.RemoveComputer("Asus", "Duck");
            Assert.That(this.computerManager.Count, Is.EqualTo(0));

        }

        [Test]
        public void GetComputer_WhenManufacturerIsNull()
        {
            this.computerManager.AddComputer(new Computer(null, "Gamer", 50));

            Assert.Throws<ArgumentNullException>(() => this.computerManager.GetComputer(null, "Gamer"));

        }

        [Test]
        public void GetComputer_WhenModelIsNull()
        {
            this.computerManager.AddComputer(new Computer("Dell", null, 50));

            Assert.Throws<ArgumentNullException>(() => this.computerManager.GetComputer("Dell", null));

        }

        [Test]
        public void GetComputer_WhenComputerDoesNotExist()
        {

            Assert.Throws<ArgumentException>(() => this.computerManager.GetComputer("Acer", "Kaun"));

        }

        [Test]
        public void GetComputer_WhenIsValidOperation()
        {
            this.computerManager.AddComputer(computer);
            Assert.That(computer, Is.EqualTo(this.computerManager.GetComputer("Asus", "Duck")));

        }

        [Test]
        public void ValidateNullValue()
        {
            Computer computer = null;
            ;
            Assert.Throws<ArgumentNullException>(() => this.computerManager.AddComputer(computer));

        }
        [Test]
        public void GetCopmuterByManufacturer_WhenIsNull()
        {
            Computer computer = new Computer(null, "GM", 50);

            Assert.Throws<ArgumentNullException>(() => this.computerManager.GetComputersByManufacturer(null));

        }

        [Test]
        public void GetCopmuterByManufacturer_WhenIsValidOperation()
        {
            this.computerManager.AddComputer(computer);

            var result = this.computerManager.GetComputersByManufacturer("Asus");

            Assert.AreEqual(result, computerManager.Computers);
            Assert.That(computerManager.Count, Is.EqualTo(1));

        }
        [Test]
        public void CounterIsEmpty()
        {
            Assert.That(this.computerManager.Count, Is.EqualTo(0));
        }

        [Test]
        public void C_Tor_Test()
        {
            Assert.AreEqual("Asus", computer.Manufacturer);
            Assert.AreEqual("Duck", computer.Model);
            Assert.AreEqual(1000, computer.Price);
            Assert.IsNotNull(computer);
        }

        [Test]
        public void Test_Computers_IReadOnly()
        {
            Computer computerOne = new Computer("Asus", "gamer", 1000);
            Computer computerTwo = new Computer("HP", "hp", 2000);
            computerManager.AddComputer(computerOne);
            computerManager.AddComputer(computerTwo);

            var comp = computerManager.Computers;

            Assert.That(comp.Count, Is.EqualTo(computerManager.Count));
        }


        [Test]
        public void GetAllByManufacturerShouldReturnCorrectCollection()
        {
            Computer computer = new Computer("Asus", "gamer", 1000);

            computerManager.AddComputer(computer);
            computerManager.AddComputer(new Computer("Asus", "K210", 899.99m));
            computerManager.AddComputer(new Computer("Hp", "P34", 420));
            var collection = computerManager.GetComputersByManufacturer("Asus");

            Assert.That(collection.Count, Is.EqualTo(2));

        }

        [Test]
        public void Counter_Test_If_NotEmpty()
        {
            Computer computer = new Computer("Asus", "gamer", 1000);
            computerManager.AddComputer(computer);

            Assert.That(computerManager.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveCompThrowException()
        {
            Computer computer = new Computer("Asus", "gamer", 1000);
            computerManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => computerManager.RemoveComputer("Hp", "gamer"));
        }
    }
    }