using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int PowerOfDruid = 80;
        public Druid(string name)
            : base(name, PowerOfDruid)
        {
        }

        public override string CastAbiliry()
        {
            return $"{nameof(Druid)} - {this.Name} healed for {this.Power}";
        }
    }
}
