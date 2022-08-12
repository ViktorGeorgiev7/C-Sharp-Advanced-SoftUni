using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        private int _year;

        private double _pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public double Pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = value;
            }
        }
    }
}
