using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        {
            this.Power = 100;
        }
        public sealed override int Power { get; set; }
        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
