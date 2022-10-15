using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck:Vehicle
    {
        private const double TruckFuelConsumptionIncrement = 1.6;
        private const double TruckRefuelCoefficient = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity) : base(fuelQuantity, fuelConsumption,tankCapacity)
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
                base.FuelConsumption = value + TruckFuelConsumptionIncrement;
            }
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (this.FuelQuantity + fuel*TruckRefuelCoefficient > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel * TruckRefuelCoefficient;
            }
        }
    }
}
