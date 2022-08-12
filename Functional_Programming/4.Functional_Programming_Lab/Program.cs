using System;
using System.Linq;

namespace _4.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            prices = prices.Select(x => x * (double) 1.20).ToArray();
            foreach (var num in prices)
            {
                Console.Write($"{num:f2}, ");
            }
        }
    }
}
