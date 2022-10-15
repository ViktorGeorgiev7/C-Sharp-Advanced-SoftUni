using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsumption,double tankCapacity);
    }
}
