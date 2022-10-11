using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla:ICar,IElectricCar
    {
        public Tesla(string model,string color,int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Model { get; set; }
        public int Battery { get; set; }
        public string Color { get; set; }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString();
        }

    }
}
