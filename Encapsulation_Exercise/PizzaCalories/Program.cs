using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaName = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string[] doughInfo = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Pizza pizza = new Pizza(pizzaName[1], new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3])));
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] placeHolders = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    pizza.AddTopping(new Topping(placeHolders[1],int.Parse(placeHolders[2])));
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
