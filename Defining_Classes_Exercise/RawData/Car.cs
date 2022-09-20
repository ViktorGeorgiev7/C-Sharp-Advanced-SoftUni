using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {//speed, power, weight, and tire age are integers.
        public Car(string model,Engine engine,Cargo cargo,List<Tires> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tires> Tires { get; set; }
    }
}
