using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        private int _horsePower;

        private double _cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
        public int HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                _horsePower = value;
            }
        }

        public double CubicCapacity
        {
            get
            {
                return _cubicCapacity;
            }
            set
            {
                _cubicCapacity = value;
            }
        }

    }
}
