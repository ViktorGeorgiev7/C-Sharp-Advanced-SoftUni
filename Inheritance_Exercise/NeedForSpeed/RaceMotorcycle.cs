using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class RaceMotorcycle:Motorcycle
    {
        public RaceMotorcycle(int hp, double fuel):base(hp,fuel)
        {
            DefaultFuelConsumption = 8;
        }

    }
}
