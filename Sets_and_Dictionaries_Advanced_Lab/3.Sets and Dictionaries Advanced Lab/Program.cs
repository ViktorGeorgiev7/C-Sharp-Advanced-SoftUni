using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace _3.Sets_and_Dictionaries_Advanced_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            numbers = numbers.OrderByDescending(x=>x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
