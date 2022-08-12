using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            IEnumerable<string> list = arr.Select(x => "Sir " + x);
            Console.WriteLine(string.Join("\n",list));

        }
    }
}
