using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Sets_and_Dictionaries_Advanced_Lab
{
    class Program
    {
        static void Main(string[] args)
        {//read
            string input = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            while (input != "PARTY")
            {
                set.Add(input);
                input = Console.ReadLine();
            }
            //main
            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command != null && set.Contains(command) && command.Length == 8)
                {
                    set.Remove(command);
                }
                command = Console.ReadLine();
            }
            //output
            Console.WriteLine(set.Count);
            foreach (var person in set)
            {
                Console.WriteLine(person);
            }
        }
    }
}
