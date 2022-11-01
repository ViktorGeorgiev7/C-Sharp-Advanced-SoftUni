using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl:Bird
    {//Owl - 0.25
        public Owl(string name, double weight, int foodEaten, string wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
