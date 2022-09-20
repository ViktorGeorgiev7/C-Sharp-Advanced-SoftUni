using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hatsInput = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int[] scarfsInput = Console.ReadLine()?
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            List<int> sets = new List<int>();
            Stack<int> hats = new Stack<int>(hatsInput!);
            Queue<int> scarfs = new Queue<int>(scarfsInput!);
            while (hats.Count > 0)
            {
                if (scarfs.Count == 0)
                {
                    break;
                }
                if (hats.Peek() > scarfs.Peek())
                {
                    sets.Add(hats.Pop()+scarfs.Dequeue());
                }
                else if (hats.Peek() == scarfs.Peek())
                {
                    scarfs.Dequeue();
                    int newValue = hats.Pop() + 1;
                    hats.Push(newValue);
                }
                else
                {
                    hats.Pop();
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(' ',sets));
        }
    }
}
