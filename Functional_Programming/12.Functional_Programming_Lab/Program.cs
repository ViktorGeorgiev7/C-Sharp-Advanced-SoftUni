using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Predicate<string> filter = s => s.Length <= n;
            names = names.FindAll(filter).ToList();
            Console.WriteLine(string.Join("\n",names));
        }
    }
}
