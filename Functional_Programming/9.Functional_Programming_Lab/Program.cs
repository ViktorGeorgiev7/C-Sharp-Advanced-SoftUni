using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _9.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> list = new List<int>();
            for (int i = nums[0]; i <= nums[1]; i++)
            {
             list.Add(i);   
            }

            string type = Console.ReadLine();
            Predicate<int> isEven = s => s % 2 == 0;
            Predicate<int> isOdd = s => s % 2 != 0;

            List<int> result = type == "even" ? list.FindAll(isEven) : list.FindAll(isOdd);

            Console.WriteLine(string.Join(' ',result));

        }
    }
}
