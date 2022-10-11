
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<IBuyer> buyers = new HashSet<IBuyer>();
            char[] delimiters = {' ', '/'};
            for (int i = 0; i < n; i++)
            {
                string[] placeHolders = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                if (placeHolders.Length == 3)
                {
                    buyers.Add(new Rebel(placeHolders[0], int.Parse(placeHolders[1]), placeHolders[2]));
                }
                else
                {
                    buyers.Add(new Citizen(placeHolders[1], int.Parse(placeHolders[2]), placeHolders[3], placeHolders[4], placeHolders[5], int.Parse(placeHolders[6])));
                }
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                foreach (var buyer in buyers)
                {
                    if (buyer.Name == input)
                    {
                        buyer.BuyFood();
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var buyer in buyers)
            {
                Console.WriteLine(buyer.Food);
                break;
            }
        }
    }
}
