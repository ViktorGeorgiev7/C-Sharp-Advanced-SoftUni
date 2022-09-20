using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {//n/a
        public Engine(string model,int power,string displacement,string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public Engine(string model,int power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string model, int power,int displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement.ToString();
            Efficiency = "n/a";
        }
        public Engine(string model, int power,string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = efficiency;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
