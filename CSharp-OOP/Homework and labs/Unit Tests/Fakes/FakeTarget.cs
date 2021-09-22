
using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Fakes
{
    public class FakeTarget : ITarget
    {
        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return false;
        }

        public void TakeAttack(int attackAmount)
        {
            
        }
    }
}
