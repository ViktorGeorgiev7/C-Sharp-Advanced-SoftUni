using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat:Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
