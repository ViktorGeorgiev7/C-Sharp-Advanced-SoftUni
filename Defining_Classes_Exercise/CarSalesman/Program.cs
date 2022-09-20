using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] placeHolders = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (placeHolders.Length == 2)
                {
                    engines.Add(new Engine(placeHolders[0],int.Parse(placeHolders[1])));
                }
                else if (placeHolders.Length == 3)
                {
                   
                }
                else if (placeHolders.Length == 4)
                {
                    
                }//lost cause
            }

        }
    }
}
