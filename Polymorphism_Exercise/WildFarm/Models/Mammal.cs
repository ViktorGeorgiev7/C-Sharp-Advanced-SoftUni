using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mammal:Animal
    {
        public Mammal(string name, double weight, int foodEaten,string livingRegion) : base(name, weight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }
        public override void ProduceSound()
        {
            
        }
    }
}
