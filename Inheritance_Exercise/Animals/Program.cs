using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string species = Console.ReadLine();
                string[] information = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (species == "Beast!")
                {
                    break;
                }

                if (int.Parse(information[1]) < 0)
                {
                    Console.WriteLine($"Invalid input!");
                    continue;
                }
                Animal animal = default;
                switch (species)
                {
                    case "Dog":
                        animal = new Dog(information[0], int.Parse(information[1]), information[2]);
                        break;
                    case "Cat":
                        animal = new Cat(information[0], int.Parse(information[1]), information[2]);
                        break;
                    case "Kitten":
                        animal = new Kitten(information[0], int.Parse(information[1]));
                        break;
                    case "Tomcat":
                        animal = new Tomcat(information[0], int.Parse(information[1]));
                        break;
                    case "Frog":
                        animal = new Frog(information[0], int.Parse(information[1]), information[2]);
                        break;
                }
                Console.WriteLine(species);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
                

            }
        }
    }
}
