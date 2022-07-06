using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace _4.Sets_and_Dictionaries_Advanced_Lab
{
    class ProductShop
    {
        public string Shop { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dictionary =
                new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                string[] placeHolders = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = placeHolders[0];
                string item = placeHolders[1];  
                double price = double.Parse(placeHolders[2]);
                if (!dictionary.ContainsKey(shop))
                {
                    dictionary.Add(shop,new Dictionary<string, double>());
                    dictionary[shop].Add(item,price);
                    
                }
                else
                {
                    dictionary[shop].Add(item,price);
                }


                input = Console.ReadLine();
            }

            dictionary = dictionary.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
                
            
            
            foreach (var shop in dictionary)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }

    }
}
