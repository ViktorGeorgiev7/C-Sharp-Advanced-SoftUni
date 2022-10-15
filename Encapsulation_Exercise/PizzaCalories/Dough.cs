using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            {"white", whiteIncrement},
            {"wholegrain", wholeGrainIncrement},
            {"crispy", crispyIncrement},
            {"chewy", chewyIncrement},
            {"homemade", HomemadeIncrement},

        };
    
        private const double whiteIncrement = 1.5;
        private const double wholeGrainIncrement = 1.0;
        private const double crispyIncrement = 0.9;
        private const double chewyIncrement = 1.1;
        private const double HomemadeIncrement = 1.0;
        private const double caloriesPerGramIncrement = 2;
        private string flourType;
        private string bakingTechnique;
        private int grams;
        public Dough(string flour,string baking,int grams)
        {
            this.Grams = grams;
            this.FlourType = flour;
            this.BakingTechnique = baking;
        }

        private int Grams
        {
            get
            {
                return grams;
            }
            set
            {
                if (value > 0 && value < 201)
                {
                    grams = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }

        private string FlourType
        {
            get
            {
                return this.flourType;
            }
            set
            {
                if (modifiers.ContainsKey(value.ToLower()))
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        private string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                if (modifiers.ContainsKey(value.ToLower()))
                {
                    this.bakingTechnique = value;
                }
                else
                {    
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double Calories => caloriesPerGramIncrement * this.Grams * modifiers[FlourType.ToLower()] * modifiers[BakingTechnique.ToLower()];
    }
}
