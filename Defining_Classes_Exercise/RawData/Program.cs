using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> catalog = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] placeHolders = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                catalog.Add(new Car(placeHolders[0],new Engine(int.Parse(placeHolders[1]),int.Parse(placeHolders[2])),new Cargo(int.Parse(placeHolders[3]),placeHolders[4]),new List<Tires>(){new Tires(double.Parse(placeHolders[5]),int.Parse(placeHolders[6])),
                    new Tires(double.Parse(placeHolders[7]),int.Parse(placeHolders[8])),
                    new Tires(double.Parse(placeHolders[9]),int.Parse(placeHolders[10])),
                    new Tires(double.Parse(placeHolders[11]),int.Parse(placeHolders[12]))}));
                //catalog[catalog.FindIndex(x => x.Model == placeHolders[0])].Tires = new List<Tires>()
                //{
                //    new Tires(int.Parse(placeHolders[5]), double.Parse(placeHolders[6])),
                //    new Tires(int.Parse(placeHolders[7]), double.Parse(placeHolders[8])),
                //    new Tires(int.Parse(placeHolders[9]), double.Parse(placeHolders[10])),
                //    new Tires(int.Parse(placeHolders[11]), double.Parse(placeHolders[12])),

                //};
            }

            string type = Console.ReadLine();

            catalog = catalog.FindAll(x => x.Cargo.Type.ToLower() == type.ToLower());
            if (type == "Flammable")
            {
                catalog = catalog.FindAll(x => x.Engine.Power > 250);
                foreach (var car in catalog)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                catalog = catalog.Where(x => x.Tires.FirstOrDefault(tire => tire.Pressure < 1) != null).ToList();
                foreach (var car in catalog)
                {
                    Console.WriteLine(car.Model);
                }
            }//flammable works//fragile works

        }
    }
}
