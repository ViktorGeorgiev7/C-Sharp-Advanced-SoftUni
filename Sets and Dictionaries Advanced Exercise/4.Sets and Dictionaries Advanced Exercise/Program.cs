using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();
                if (!dictionary.ContainsKey(num))
                {
                    dictionary.Add(num,0);
                }

                dictionary[num]++;
            }
            
            foreach (var kvp in dictionary)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }

        }
    }
}
