using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet:IBirthable
    {
        public Pet(string name,string day,string month,int year)
        {
            Name = name;
            Year = year;
            Month = month;
            Day = day;
        }
        public string Name { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
    }
}
