using System;
using System.Collections.Generic;

namespace _7.Sets_and_Dictionaries_Advanced_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> set = new HashSet<string>();
            while (input != "END")
            {
                string[] placeHolders = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string command = placeHolders[0];
                if (command == "IN")
                {
                    set.Add(placeHolders[1]);
                }
                else if (command == "OUT" && set.Contains(placeHolders[1]))
                {
                    set.Remove(placeHolders[1]);
                }
                input = Console.ReadLine();
            }

            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");   
            }
            else
            {
                foreach (var car in set)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
