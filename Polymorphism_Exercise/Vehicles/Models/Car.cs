using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car:Vehicle
    {
        private const double CarFuelConsumptionIncrement = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption;
            }
            protected set
            {
                base.FuelConsumption = value + CarFuelConsumptionIncrement;
            }
        }
    }
}
