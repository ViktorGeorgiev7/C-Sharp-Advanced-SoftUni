using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen:Bird
    {
        public Hen(string name, double weight, int foodEaten, string wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
