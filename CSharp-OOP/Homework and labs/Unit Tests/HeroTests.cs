using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tests.Fakes;

namespace Tests
{
    [TestFixture]
    public class HeroTests
    {
        [Test]

        public void WhenTargetDies_ShoulReceiveExpirience()
        {
            FakeWeapon weapon = new FakeWeapon();
            FakeTarget target = new FakeTarget();
            Hero hero = new Hero("Krasi", weapon);

            hero.Attack(target);
            Assert.That(hero.Experience, Is.EqualTo(0));

        }
    }
}
