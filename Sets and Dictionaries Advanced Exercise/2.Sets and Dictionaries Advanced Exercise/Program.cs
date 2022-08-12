using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _2.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = arr[0];
            int m = arr[1];
            SortedSet<int> setOne = new SortedSet<int>();
            SortedSet<int> setTwo = new SortedSet<int>();

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                setOne.Add(a);
            }

            for (int i = 0; i < m; i++)
            {
                int b = int.Parse(Console.ReadLine());
                setTwo.Add(b);
            }

            HashSet<int> unique = new HashSet<int>();
            if (setOne.Count > setTwo.Count)
            {
                foreach (var num in setOne)
                {
                    foreach (var number in setTwo)
                    {
                        if (num == number)
                        {
                            unique.Add(num);
                        }
                    }
                }
            }
            else if (setTwo.Count > setOne.Count)
            {
                foreach (var num in setTwo)
                {
                    foreach (var number in setOne)
                    {
                        if (num == number)
                        {
                            unique.Add(num);
                        }
                    }
                }
            }
            else
            {
                foreach (var num in setOne)
                {
                    foreach (var number in setTwo)
                    {
                        if (num == number)
                        {
                            unique.Add(num);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ',unique));
        }
    }
}
