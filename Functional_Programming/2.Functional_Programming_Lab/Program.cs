using System;
using System.Linq;

namespace _2.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(arr.Length);//10
            Console.WriteLine(arr.Sum());//41
        }
    }
}
