using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> reservations = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input !="Party!")
            {
                string[] placeholders = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string doubleRemove = placeholders[0];
                string startEndLenght = placeholders[1];
                switch (doubleRemove)
                {
                    case "Double":
                        switch (startEndLenght)
                        {
                            case "StartsWith":
                                foreach (var member in reservations.ToList())
                                {
                                    if (member.StartsWith(placeholders[2]))
                                    {
                                        reservations.Add(member);
                                    }
                                }
                                break;
                            case "EndsWith":
                                foreach (var member in reservations.ToList())
                                {
                                    if (member.EndsWith(placeholders[2]))
                                    {
                                        reservations.Add(member);
                                    }
                                }
                                break;
                            case "Length":
                                foreach (var member in reservations.ToList())
                                {
                                    if (member.Length == int.Parse(placeholders[2]))
                                    {
                                        reservations.Add(member);
                                    }
                                }
                                break;
                        }
                        break;
                    case "Remove":
                    case "StartsWith":
                        foreach (var member in reservations.ToList())
                        {
                            if (member.StartsWith(placeholders[2]))
                            {
                                reservations.Remove(member);
                            }
                        }
                        break;
                    case "EndsWith":
                        foreach (var member in reservations.ToList())
                        {
                            if (member.EndsWith(placeholders[2]))
                            {
                                reservations.Remove(member);
                            }
                        }
                        break;
                    case "Length":
                        foreach (var member in reservations.ToList())
                        {
                            if (member.Length == int.Parse(placeholders[2]))
                            {
                                reservations.Remove(member);
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            if (reservations.Any())
            {
                Console.WriteLine(string.Join(", ", reservations.OrderBy(x=>x)) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
        }
    }
}
