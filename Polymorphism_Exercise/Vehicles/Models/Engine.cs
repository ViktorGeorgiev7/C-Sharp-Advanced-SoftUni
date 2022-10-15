using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Engine : IEngine
    {
        private readonly Vehicle car;
        private readonly Vehicle truck; 
        private readonly Bus bus;
        public Engine(Vehicle car,Vehicle truck,Vehicle bus)
        {
            this.car = car;
            this.truck = truck;
            this.bus = (Bus)bus;
        }

        public void Start()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                double value = double.Parse(input[2]);
                switch (command)
                {
                    case "Drive":
                        if (input[1] == "Car")
                        {
                            Console.WriteLine(car.Drive(value));
                        }
                        else if (input[1] == "Truck")
                        {
                            Console.WriteLine(truck.Drive(value));
                        }
                        else if(input[1] == "Bus")
                        {
                            Console.WriteLine(bus.Drive(value));
                        }
                        break;
                    case "Refuel":
                        if (input[1] == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (input[1] == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else if(input[1] == "Bus")
                        {
                            bus.Refuel(value);
                        }
                        break;
                    case "DriveEmpty":
                        if (input[1] == "Bus")
                        {
                            Console.WriteLine(bus.DriveEmpty(value));
                        }
                        break;

                }
            }
            Console.WriteLine(this.car);
            Console.WriteLine(this.truck);
            Console.WriteLine(this.bus);
        }
    }
}
