using System;
using System.Collections.Generic;

namespace _3.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] placeHolders = Console.ReadLine()?.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in placeHolders)
                {
                    set.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ',set));
        }
    }
}
