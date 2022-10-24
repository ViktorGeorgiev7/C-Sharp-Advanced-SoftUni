using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _01.Loot_box
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] firstBoxArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
             Queue<int> firstBox = new Queue<int>(firstBoxArr);
             Stack<int> secondBox = new Stack<int>(secondBoxArr);
             List<int> items = new List<int>();
             while (true)
             {
                 if (!firstBox.Any())
                 {
                     Console.WriteLine("First lootbox is empty");
                     break;
                 }

                 if (!secondBox.Any())
                 {
                     Console.WriteLine("Second lootbox is empty");
                     break;
                 }
                 int result = firstBox.Peek() + secondBox.Peek();
                 if (result % 2 == 0)
                 {
                     items.Add(firstBox.Dequeue()+secondBox.Pop());
                 }
                 else
                 {
                     firstBox.Enqueue(secondBox.Pop());
                 }
             }

             if (items.Sum() >= 100)
             {
                 Console.WriteLine($"Your loot was epic! Value: {items.Sum()}");
             }
             else
             {
                 Console.WriteLine($"Your loot was poor... Value: {items.Sum()}");
             }
        }
    }
}

