using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> set = new List<string>();
            while (input!="End")
            {
                string[] placeHolders = input.Split(' ');
                set.Add(placeHolders[^1]);
                input = Console.ReadLine();
            }

            HashSet<string> detained = new HashSet<string>();
            string nums = Console.ReadLine();
            foreach (var value in set)
            {
                if (value.EndsWith(nums))
                {
                    detained.Add(value);
                }
            }
            Console.WriteLine(string.Join("\n",detained));
        }
    }
}
