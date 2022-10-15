using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
         public double FuelQuantity { get;}
         public double TankCapacity { get;}
         public double FuelConsumption { get;}
         string Drive(double distance);
         void Refuel(double fuel);
    }
}
