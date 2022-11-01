using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal//Animal – string Name, double Weight, int FoodEaten--abstract
    {
        protected Animal(string name, double weight, int foodEaten)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public abstract void ProduceSound();
        public string Name { get;}
        public double Weight { get; set; }
        public virtual int FoodEaten { get; set; }
    }
}
