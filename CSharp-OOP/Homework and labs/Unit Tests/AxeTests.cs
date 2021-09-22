using NUnit.Framework;
using System;


namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        private int durabilityPoint;
        private int attackPoints;
        private int healthPoint;
        private int expiriance;
        private Axe axe;
        private Dummy dummy;

        [SetUp]

        public void SetUp()
        {
            this.durabilityPoint = 10;
            this.attackPoints = 10;
            axe = new Axe(this.attackPoints, this.durabilityPoint);
            this.healthPoint = 10;
            this.expiriance = 10;
            dummy = new Dummy(this.healthPoint, this.expiriance);
        }

        [Test]

        public void AxeLosesDurabilityAfterAttack()
        {
            
            axe.Attack(dummy);

            Assert.AreEqual(durabilityPoint - 1, axe.DurabilityPoints);
        }

        [Test]

        public void AttackinWithBrokenWeapon()
        {
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);

            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException
                .With.Message.EqualTo("Axe is broken."));
           
        }


    }
}
