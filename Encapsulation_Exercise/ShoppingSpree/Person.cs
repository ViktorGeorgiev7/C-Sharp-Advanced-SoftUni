using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bag;

        public Person(string name,int money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public int Money
        {
            get
            {
                return money;
            }
            private set
            {
                money = value;
            }
        }

        public List<Product> Bag
        {
            get
            {
                return bag;
            }
            private set
            {
                bag = value;
            }
        }
    }
}
