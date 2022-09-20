using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Vehicle
    {
        public Vehicle(int hp,double fuel)
        {
            HorsePower = hp;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
        }
        public double DefaultFuelConsumption  { get; set; }
        public virtual double FuelConsumption  { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            Fuel -= DefaultFuelConsumption * kilometers;
        }
    }
}
