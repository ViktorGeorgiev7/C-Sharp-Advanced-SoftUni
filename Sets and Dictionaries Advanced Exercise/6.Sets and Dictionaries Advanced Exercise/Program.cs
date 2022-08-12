using System;
using System.Collections.Generic;

namespace _6.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] placeHolders = input.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string color = placeHolders[0];
                string secondPlace = placeHolders[1];
                string[] clothes = secondPlace.Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color,new Dictionary<string, int>());
                }

                foreach (var cloth in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth,0);
                    }

                    wardrobe[color][cloth]++;
                }

            }

            string[] search = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = search[0];
            string searchedCloth = search[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothing in color.Value)
                {
                    if (clothing.Key == searchedCloth && color.Key == searchedColor)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
