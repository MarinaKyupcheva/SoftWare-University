using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;
        private UnitDriver driver;

        [SetUp]
        public void Setup()
        {
            this.raceEntry = new RaceEntry();
            this.driver = new UnitDriver("Sasho", new UnitCar("Ferrary", 120, 200));
        }

        [Test]
        public void SetCounterToNull()
        {
            Assert.That(raceEntry.Counter, Is.EqualTo(0));
        }

        [Test]
        public void CounterIsExceeded()
        {
            raceEntry.AddDriver(driver);
            var expectetCount = 1;
            Assert.That(raceEntry.Counter, Is.EqualTo(expectetCount));
        }
        [Test]
        public void ConstrictorInitializeCollection()
        {
            Assert.That(raceEntry.Counter, Is.Not.Null);
        }
        [Test]
        public void ThrowExceptionWhenDriverIsNull()
        {
          Exception ex =  Assert.Throws<InvalidOperationException>(() =>raceEntry.AddDriver(null));
            
        }
        [Test]
        public void ThrowExceptionWhenDriverIsAlreadyAdded()
        {
            raceEntry.AddDriver(driver);
            Exception ex = Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(driver));

        }
        [Test]
        public void WhenAddIsCorrect()
        {
            raceEntry.AddDriver(driver);
            Assert.That(raceEntry.Counter, Is.EqualTo(1));

        }

        [Test]
        public void CalculateAvarageHPWhenThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());

        }

        [Test]
        public void CalculateAvarageHPWhenWorksCorrect()
        {
            raceEntry.AddDriver(driver);
            raceEntry.AddDriver(new UnitDriver("gogo", new UnitCar("Ferrary", 120, 100)));

            var expected = 120;

            Assert.That(raceEntry.CalculateAverageHorsePower(), Is.EqualTo(expected));


        }
    }
}