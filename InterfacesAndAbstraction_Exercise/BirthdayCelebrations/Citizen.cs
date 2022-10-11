using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen:IIdentifiable,IBuyer
    {
        public Citizen(string name,int age,string id,string day,string month,int year)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
        public string Name { get; set; }
        public int Food { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
