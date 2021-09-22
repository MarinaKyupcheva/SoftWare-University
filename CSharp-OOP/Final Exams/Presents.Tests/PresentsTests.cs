namespace Presents.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PresentsTests
    {
        [Test]

        public void CreatePresen_WhenIsInvalid()
        {
            Bag bag = new Bag();
            Assert.Throws<ArgumentNullException>(() => bag.Create(null));
        }
        [Test]

        public void CreatePresen_WhenExist()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]

        public void CreatePresen_WhenIsSuccessfull()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);
            //bag.Create(present);
            var message = bag.Create(present);

            Assert.AreEqual($"Successfully added present {present.Name}.", message);
        }

        [Test]

        public void Remove()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);
            bag.Create(present);
            //bag.Remove(present);

            Assert.That(bag.Remove(present)); ;
        }

        [Test]
        public void GetPresentsWihtLeastMagic()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            bag.Create(new Present("Asus", 89.20));
            bag.Create(new Present("Car", 100.00));
            var collection = bag.GetPresentWithLeastMagic();

            Assert.That(present.Magic, Is.EqualTo(2.00));

        }

        [Test]
        public void GetPresentsShouldWork()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            var expectedPresent = present;
            //var actualPresent = ("Doll", 2.00);

            Assert.AreEqual(expectedPresent, present);

        }
        [Test]
        public void GetPresentByName()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            bag.Create(new Present("Asus", 89.20));

            bag.GetPresent("Asus");

            Assert.That(present.Name, Is.EqualTo("Doll"));

        }

        [Test]
        public void IfConstructorInicializeColection()
        {
            Bag bag = new Bag();
            Assert.That(bag, Is.Not.Null);

        }

        [Test]
        public void GetPresentsMethod()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            bag.Create(new Present("Asus", 89.20));
            bag.Create(new Present("Car", 100.00));
            var collection = bag.GetPresents();

            Assert.That(collection.Count, Is.EqualTo(3));

        }

        [Test]
        public void C_Tor_Test()
        {

            Present present = new Present("Doll", 2.00);
            Assert.AreEqual("Doll", present.Name);
            Assert.AreEqual(2.00, present.Magic);

            Assert.IsNotNull(present);
        }

        [Test]
        public void Test_CreatePresent_WithParameters()
        {


            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

           
            bag.Create(new Present("Asus", 89.20));
            bag.Create(new Present("Car", 100.00));
            
            var message = bag.Create(present);


            Assert.That(message, Is.EqualTo($"Successfully added present {present.Name}."));





        }

        [Test]
        public void Test_CreatePresent_WithInvalidParameters_ExistingPresent()
        {


            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            bag.Create(new Present("Asus", 89.20));
            bag.Create(new Present("Car", 100.00));           

           
            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                bag.Create(present);
            }
            );

            Assert.AreEqual("This present already exists!", ex.Message);




        }


        [Test]
        public void GetPresetByNameTwo()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            bag.Create(new Present("Asus", 89.20));
            var name = bag.GetPresent("Asus");

            Assert.That(bag.GetPresent("Asus"),Is.EqualTo(name));

        }

        [Test]
        public void Test_IReadOnly()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            bag.Create(new Present("Asus", 89.20));

            var pres = bag.GetPresents();

            Assert.That(bag.GetPresents().Count, Is.EqualTo(pres.Count));
        }

        [Test]
        public void GetPresentsShouldWork1()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            var expectedPresent = present;
            //var actualPresent = ("Doll", 2.00);

            Assert.AreEqual(expectedPresent, bag.GetPresent("Doll"));

        }
        [Test]
        public void GetPresentsShouldWork3()
        {
            Bag bag = new Bag();
            Present present = new Present("Doll", 2.00);

            bag.Create(present);
            //var expectedPresent = present;
            //var actualPresent = ("Doll", 2.00);
            bag.Create(new Present("Asus", 89.20));

            var pres = bag.GetPresents();

            Assert.AreEqual(pres.Count, bag.GetPresents().Count);

        }

    }
}
