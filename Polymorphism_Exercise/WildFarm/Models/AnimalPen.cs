using System;
namespace WildFarm
{
    public class AnimalPen
    {
        private Animal animal;
        public Animal CreateAnimal(string type, string name, double weight,string regionOrWing,string breed,string foodType,int value) 
        {
            //breed will be null if animal is other than feline
            switch (type)
            {
                case "Dog":
                    if (foodType == "Meat")
                    {
                        Console.WriteLine("Woof!");
                        weight += value * 0.40;
                    }
                    else
                    {
                        Console.WriteLine("Woof!");
                        value = 0;
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }
                    return animal = new Dog(name, weight, value, regionOrWing);
                case "Cat":
                    if (foodType == "Meat" || foodType == "Vegetable")
                    {
                        Console.WriteLine("Meow");
                        weight += 0.30 * value;
                    }
                    else
                    {
                        Console.WriteLine("Meow");
                        value = 0;
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }
                    return animal = new Cat(name, weight, value, regionOrWing, breed);
                case "Tiger":
                    if (foodType == "Meat")
                    {
                        Console.WriteLine($"ROAR!!!");
                        weight += value * 1;
                    }
                    else
                    {
                        Console.WriteLine($"ROAR!!!");
                        value = 0;
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }
                    return animal = new Tiger(name, weight, value, regionOrWing, breed);
                case "Hen":
                    weight += value * 0.35;
                    Console.WriteLine("Cluck");
                    return animal = new Hen(name,weight,value,regionOrWing);
                case "Mouse"://0.10
                    if (foodType == "Vegetable" || foodType == "Fruit")
                    {
                        Console.WriteLine("Squeak");
                        weight += 0.10 * value;
                    }
                    else
                    {
                        Console.WriteLine("Squeak");
                        value = 0;
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }
                    return animal = new Mouse(name, weight, value, regionOrWing);
                case "Owl"://0.25
                    if (foodType == "Meat")
                    {
                        Console.WriteLine("Hoot Hoot");
                        weight += 0.25 * value;
                    }
                    else
                    {
                        Console.WriteLine("Hoot Hoot");
                        value = 0;
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }
                    return animal = new Owl(name, weight, value, regionOrWing);
            }

            return null;
        }
    }
}
