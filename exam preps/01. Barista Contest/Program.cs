using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Barista_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> beverages = new Dictionary<string, int>()
            {
                {"Cortado",50},
                {"Espresso",75},
                {"Capuccino",100},
                {"Americano",150},
                {"Latte",200}
            };
            int[] coffeArr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] milkArr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> coffe = new Queue<int>(coffeArr);
            Stack<int> milk = new Stack<int>(milkArr);
            Dictionary<string, int> boughtItems = new Dictionary<string, int>()
            {
                {"Cortado",0},
                {"Espresso",0},
                {"Capuccino",0},
                {"Americano",0},
                {"Latte",0}
            };
            
            while (true)
            {
                if ((!coffe.Any() && !milk.Any()))
                {
                    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
                    break;
                }
                if (!coffe.Any())//coffe ends first
                {
                    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
                    break;
                }

                if ((!milk.Any()))//milk ends first
                {
                    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
                    break;
                }

                bool isMade = false;
                foreach (var kvp in beverages)
                {
                    int result = coffe.Peek() + milk.Peek();
                    if (result == kvp.Value)
                    {
                        boughtItems[kvp.Key]++;
                        coffe.Dequeue();
                        milk.Pop();
                        isMade = true;
                        break;
                    }
                }

                if (!isMade)
                {
                    coffe.Dequeue();
                    milk.Push(milk.Pop()-5);
                }
            }


            var firstLine = coffe.Count == 0 && milk.Count == 0
                ? "Nina is going to win! She used all the milk and coffee!"
                : "Nina needs to exercise more! She didn't use all the milk and coffee!";
            Console.WriteLine(firstLine);
            //second line
            var coffeeLeft = coffe.Count == 0 ? "none" : String.Join(", ", milk);
            Console.WriteLine($"Coffee left: {coffeeLeft}");
            //third line
            var milkLeft = coffe.Count == 0 ? "none" : String.Join(", ", milk);
            Console.WriteLine($"Milk left: {milkLeft}");
            foreach (var drink in boughtItems.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (drink.Value == 0)
                {
                }
                else
                {
                    Console.WriteLine($"{drink.Key}: {drink.Value}");
                }
            }
        }
    }
}
