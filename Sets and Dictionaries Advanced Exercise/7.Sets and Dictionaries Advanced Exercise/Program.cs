using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _7.Sets_and_Dictionaries_Advanced_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> logger = new Dictionary<string, List<string>>();

            while (input != "Statistics")
            {
                string[] placeHolders = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string vlogger = placeHolders[0];
                string command = placeHolders[1];
                string followed = placeHolders[2];
                if (command == "joined" && !logger.ContainsKey(vlogger))
                {
                    logger.Add(vlogger,new List<string>());
                }
                else if(command == "followed" && logger.ContainsKey(vlogger) && logger.ContainsKey(followed) && vlogger != followed && !logger[vlogger].Contains(followed))
                {
                    logger[vlogger].Add(followed);
                }

                input = Console.ReadLine();
            }

            logger = new Dictionary<string, List<string>>(logger.OrderByDescending(x=>logger.Values.Count));
            int counter = 0;
            Console.WriteLine($"The V - Logger has a total of {logger.Count} vloggers in its logs.");
            foreach (var vlogger in logger)
            {
                if (counter == 0)
                {
                    counter++;
                    Console.WriteLine($"{vlogger.Key} : {vlo}");
                }
            }
        }
    }
}
