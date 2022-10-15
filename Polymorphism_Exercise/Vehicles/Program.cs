using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var busInfo = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries); 
            IVehicleFactory factory = new VehicleFactory();
            Vehicle car = factory.CreateVehicle(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]),double.Parse(carInfo[3]));
            Vehicle truck = factory.CreateVehicle(truckInfo[0], double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Vehicle bus = factory.CreateVehicle(busInfo[0], double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            IEngine engine = new Engine(car,truck,bus);
            engine.Start();
            
        }
    }
}
