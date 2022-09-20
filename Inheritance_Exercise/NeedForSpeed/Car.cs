using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Car:Vehicle
    {
        public Car(int hp,double fuel) : base(hp,fuel)
        {
            DefaultFuelConsumption = 3;
        }
    }
}
