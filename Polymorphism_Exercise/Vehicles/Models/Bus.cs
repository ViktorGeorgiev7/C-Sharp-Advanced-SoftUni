using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus:Vehicle
    {
        private const double BusFullFuelConsumuptionIncrement = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }
        
        //TODO empty tank and full tank 
        public string DriveEmpty(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;
            if (fuelNeeded > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            this.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        public override string Drive(double distance)
        {
            double fuelNeeded = distance * (this.FuelConsumption+1.4);
            if (fuelNeeded > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            this.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }
}
