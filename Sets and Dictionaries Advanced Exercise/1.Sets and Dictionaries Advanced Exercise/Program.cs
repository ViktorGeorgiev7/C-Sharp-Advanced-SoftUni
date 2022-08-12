using System;
using System.Collections.Generic;

namespace _1.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }

            Console.WriteLine("-----------------z");
            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
