using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid:BaseHero
    {
        public Druid(string name):base(name)
        {
            this.Power = 80;
        }
        public sealed override int Power { get; set; }

        public override string CastAbility()
        {
            return $"Druid - {Name} healed for {Power}";
        }
    }
}
