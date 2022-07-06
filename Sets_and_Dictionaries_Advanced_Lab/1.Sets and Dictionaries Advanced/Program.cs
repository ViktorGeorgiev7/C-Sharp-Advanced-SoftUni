using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Sets_and_Dictionaries_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> nums = new Dictionary<double, int>();
            foreach (var t in arr)
            {
                if (!nums.ContainsKey(t))
                {
                    nums.Add(t,0);
                }

                nums[t]++;
            }

            foreach (var occurence in nums)
            {
                Console.WriteLine($"{occurence.Key} - {occurence.Value} times");
            }
        }
    }
}
