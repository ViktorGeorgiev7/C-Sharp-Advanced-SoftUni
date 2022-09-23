using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.Blacksmith
{
    class Program
    {
        static void Main(string[] args)//You should start from the first steel and try to mix it with the last carbon
        {
            int[] steelArr = Console.ReadLine()?
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 
           int[] carbonArr = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           Dictionary<string, int> dictCost = new Dictionary<string, int>();
           dictCost.Add("Gladius",70);
           dictCost.Add("Shamshir",80);
           dictCost.Add("Katana",90); 
           dictCost.Add("Sabre", 110); 
           dictCost.Add("Broadsword", 150);
           Dictionary<string, int> recipe = new Dictionary<string, int>();
           Queue<int> steel = new Queue<int>(steelArr ?? Array.Empty<int>());
           Stack<int> carbon = new Stack<int>(carbonArr ?? Array.Empty<int>());
            var steelRanOut = false; var carbonRanOut = false;

            while (true)
            {
               if (!steel.Any())
               {
                    steelRanOut = true;
                    break;
               }
               if (!carbon.Any())
               {
                    carbonRanOut = true;
                    break;
               }
               bool isCreated = false;
               int steelValue = steel.Peek();
               int carbonValue = carbon.Peek();
               int result = steelValue + carbonValue;
               foreach (var kvp in dictCost)
               {
                   if (result == kvp.Value)
                   {
                        isCreated = true;
                        steel.Dequeue();
                        carbon.Pop();
                        if (recipe.ContainsKey(kvp.Key))
                        {
                            recipe[kvp.Key]++;
                        }
                        else
                        {
                            recipe.Add(kvp.Key, 1);
                        }
	               }
               }
               if (!isCreated)
               {
                    steel.Dequeue();
                    int value = carbon.Pop()+5;
                    carbon.Push(value);
               }
            }

            int sum = 0;
            foreach (var value in recipe.Values)
            {
                sum += value;
            }
            if (recipe.Any())
            {
                Console.WriteLine($"You have forged {sum} swords.");
            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }

            if (steelRanOut)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ",steel)}");
            } 

            if (carbonRanOut)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            foreach (var kvp in recipe.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
