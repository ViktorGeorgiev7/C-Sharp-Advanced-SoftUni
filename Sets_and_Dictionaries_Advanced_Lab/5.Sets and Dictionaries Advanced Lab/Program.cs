using System;
using System.Collections.Generic;

namespace _5.Sets_and_Dictionaries_Advanced_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dictionary =
                new Dictionary<string, Dictionary<string, List<string>>>();
            List<string> empty = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (dictionary.ContainsKey(continent))
                {
                    if (dictionary[continent].ContainsKey(country))
                    {
                        dictionary[continent][country].Add(city);
                    }
                    else
                    {
                        dictionary[continent].Add(country, new List<string>());
                        dictionary[continent][country].Add(city);
                    }
                }
                else
                {
                    dictionary.Add(continent,new Dictionary<string, List<string>>());
                    dictionary[continent].Add(country,new List<string>());
                    dictionary[continent][country].Add(city);
                }
            }

            foreach (var continent in dictionary)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
