using System;
using System.Collections.Generic;

namespace _5.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            if (text != null)
            {   foreach (char element in text)
                {
                    if (!dictionary.ContainsKey(element))
                    {
                        dictionary.Add(element, 0);
                    }

                    dictionary[element]++;
                }
            }

            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s");
            }
        }
    }
}
