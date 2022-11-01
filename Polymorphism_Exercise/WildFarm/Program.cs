using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            AnimalPen pen = new AnimalPen();
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] foodInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Animal animal;
            List<Animal> list = new List<Animal>();
            while (true)
            {//todo make exception for wrong food appear after Sound?somehow?
                //todo set foodEaten to 0 for the current animal if the food doesn't exist
                if (input.Length==4)
                {
                    animal = pen.CreateAnimal(input[0], input[1], double.Parse(input[2]), input[3], null, foodInput[0],int.Parse(foodInput[1]));
                    list.Add(animal);
                }

                if (input.Length == 5)
                {
                    animal = pen.CreateAnimal(input[0], input[1], double.Parse(input[2]), input[3], input[4], foodInput[0],
                        int.Parse(foodInput[1]));
                    list.Add(animal);
                }

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                foodInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            list.ForEach(Console.WriteLine);
        }
    }
}
