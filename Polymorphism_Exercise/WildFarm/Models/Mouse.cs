using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse:Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
