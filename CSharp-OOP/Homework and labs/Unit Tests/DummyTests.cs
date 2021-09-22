using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DummyTests
    {
        private int health;
        private int expirience;
        private Dummy dummy;
        private int attackPoints;
      

        [SetUp]
        
        public void SetUp()
        {
            this.health = 10;
            this.expirience = 10;
            dummy = new Dummy(this.health, this.expirience);
            this.attackPoints = 5;
           
        }

        [Test]

        public void TakeAttakc_IfDummyIsDead_ThrowsException()
        {
            dummy = new Dummy(0, 10);
         

            Assert.That(() => this.dummy.TakeAttack(attackPoints), Throws.InvalidOperationException
              .With.Message.EqualTo("Dummy is dead."));
           
        }

        [Test]

        public void TakeAttack_WhenIsValidOperation()
        {
            this.dummy.TakeAttack(attackPoints);
           
            Assert.That(this.dummy.Health, Is.EqualTo(5));
        }

        [Test]

        public void GiveExpirience_WhenTargetIsNotDead_ThrowsException()
        {
            Assert.That(() => this.dummy.GiveExperience(), Throws.InvalidOperationException
               .With.Message.EqualTo("Target is not dead."));
          
        }

        [Test]

        public void GiveExpirience_WhenTargetIsDead_GivesExpirience()
        {
            dummy = new Dummy(0, 10);
           
            Assert.That(expirience, Is.EqualTo(this.dummy.GiveExperience()));
        }

        [Test]
        [TestCase(null)]
        [TestCase(-10)]

        public void IfDummy_IsDead_HealthIsEqualOrLowerThanNull(int health)
        {
            dummy = new Dummy(health, 10);

            Assert.That(this.dummy.IsDead(), Is.True);
        }

        [Test]

        public void ThisHealth_ReturnHealth()
        {
            

            Assert.That(this.dummy.Health, Is.EqualTo(health));
        }

        [Test]
       

        public void IfDummy_IsNotDead_ReturnFalse()
        {
            

            Assert.That(this.dummy.IsDead(), Is.False);
        }

    }
}
