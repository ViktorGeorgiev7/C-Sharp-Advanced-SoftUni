﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        public Animal(string name,string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
