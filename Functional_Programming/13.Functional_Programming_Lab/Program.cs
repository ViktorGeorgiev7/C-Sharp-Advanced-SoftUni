using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> nums = Enumerable.Range(1, range).ToList();
            Func<int, int, bool> isDivs = (x, y) => x % y == 0;
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            foreach (var number in dividers)
            {
                predicates.Add(x=> number % x == 0);
            }

            foreach (var num in nums)
            {
                bool isDiv = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(num))
                    {
                        isDiv = false;
                        break;
                    }

                    if (isDiv)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}
