using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            toppings = new List<Topping>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 15 && value.Length >=1)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }
        public Dough Dough
        {
            get
            {
                return dough;
            }
            set
            {
                dough = value;
            }
        }

        public double Calories => Dough.Calories + toppings.Select(x=>x.Calories).Sum();

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");  
            }
            toppings.Add(topping);
        }
    }
}
