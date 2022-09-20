using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {//speed, power, weight, and tire age are integers.
        public Cargo(int weight, string type)
        {
            Type = type;
            Weight = weight;
        }
        public string Type { get; set; }
        public int Weight { get; set; }
    }
}
