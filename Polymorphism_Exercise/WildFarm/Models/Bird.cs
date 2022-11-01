using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Bird:Animal
    {
        protected Bird(string name, double weight, int foodEaten,string wingSize) : base(name, weight, foodEaten)
        {
            this.WingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

        public string WingSize { get; set; }
    }
}
