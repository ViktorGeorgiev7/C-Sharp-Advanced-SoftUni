using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int divider = int.Parse(Console.ReadLine());
            Predicate<int> predicate = i => i % divider == 0;

            nums.RemoveAll(predicate);
            nums.Reverse();

            Console.WriteLine(string.Join(' ',nums));
        }
    }
}
