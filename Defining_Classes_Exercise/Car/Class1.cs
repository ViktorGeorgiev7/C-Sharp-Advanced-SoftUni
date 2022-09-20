using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {
        public Car(string model,double fuel,double consumption)
        {
            Model = model;
            FuelAmount = fuel;
            FuelConsumptionPerKilometer = consumption;
            TraveledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TraveledDistance{ get; set; }

        public void Drive(string model,double distance)
        {

            if (FuelAmount > FuelConsumptionPerKilometer*distance)
            {
                FuelAmount -= FuelConsumptionPerKilometer*distance;
                TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
