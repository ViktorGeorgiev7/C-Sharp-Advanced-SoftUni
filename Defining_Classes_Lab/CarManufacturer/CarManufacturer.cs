using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string _make;

        private string _model;

        private int _year;

        private double _fuelQuantity;

        private double _fuelConsumption;

        private Engine _engine;

        private List<Tire> _tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make,string model,int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year,double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption,Engine engine,List<Tire> tires):this(make,model,year,fuelQuantity,fuelConsumption)
        {
            Engine = engine;
            Tires = tires;

        }

        public Engine Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                _engine = value;
            }
        }

        public List<Tire> Tires
        {
            get
            {
                return _tires;
            }
            set
            {
                _tires = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return _fuelQuantity;
            }
            set
            {
                _fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return _fuelConsumption;
            }
            set
            {
                _fuelConsumption = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public void Drive(double distance)
        {
            double fuel = distance / 100 * FuelConsumption;

            if (fuel < FuelConsumption)
            {
                this.FuelQuantity -= fuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {


            var result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            result.Append($"FuelQuantity: {this.FuelQuantity}");

            return result.ToString();
        }
    }
}

