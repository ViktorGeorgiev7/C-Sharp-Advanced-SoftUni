
using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Topping
    {
        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            {"meat",1.2},
            {"veggies",0.8},
            {"cheese",1.1},
            {"sauce",0.9}
        };

        private const int gramsIncrement = 2;
        private int grams;
        private string type;

        public Topping(string type,int grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        private string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }

        private int Grams
        {
            get
            {
                return grams;
            }
            set
            {
                if (value > 0 && value <= 50)
                {
                    grams = value;
                }
                else
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
            }
        }

        public double Calories => gramsIncrement * this.Grams * modifiers[Type.ToLower()];
    }
}
