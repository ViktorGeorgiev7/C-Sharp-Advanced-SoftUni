using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
        public Tires(double pressure, int age)
        {
            Age = age;
            Pressure = pressure;
        }
        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}
