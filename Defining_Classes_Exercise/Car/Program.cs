using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Car
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> list = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] placeHolders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                list.Add(new Car(placeHolders[0],double.Parse(placeHolders[1]),double.Parse(placeHolders[2])));
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] placeHolders = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int currIndex = list.FindIndex(x => x.Model == placeHolders[1]);
                list[currIndex].Drive(placeHolders[1],int.Parse(placeHolders[2]));
                input = Console.ReadLine();
            }

            foreach (var car in list)//"{model} {fuelAmount} {distanceTraveled}"
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance:f2}");
            }
        }
    }
}
