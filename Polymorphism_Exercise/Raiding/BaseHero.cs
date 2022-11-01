using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public abstract int Power { get; set; }
        public abstract string CastAbility();
    }
}
