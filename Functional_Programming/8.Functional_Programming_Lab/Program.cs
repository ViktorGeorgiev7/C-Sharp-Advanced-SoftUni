using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace _8.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)//1 4 3 2 1 7 13
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[],int> func = s => s.Min();
            Console.WriteLine(func(arr));
        }
    }
}
