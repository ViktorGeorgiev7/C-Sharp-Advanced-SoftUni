using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model,Engine engine,string weight,string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public Car(string model, Engine engine, int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight.ToString();
        }
        public Car(string model, Engine engine, string color)
        {
            Model = model;
            Engine = engine;
            Color = color;
        }
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
    }
}
